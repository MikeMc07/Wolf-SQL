using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyScintilla.Stylers;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace WolfSQL
{
    public partial class WSQLWindow : Form
    {
        private SQLiteConnection conn = null;
        private DataTable Results = null;
        private bool is_root = false;
        private string sql_filename = null;

        public WSQLWindow(bool beRoot = false)
        {
            InitializeComponent();
            this.simpleEditor1.Styler = new SqllisteStyler();
            this.is_root = beRoot;
        }

        void CheckConnection()
        {
            if(this.conn == null || this.conn.State == ConnectionState.Closed)
            {
                this.DbConnectionLabel.Text = "No DB";
                this.DbConnectionLabel.Image = Properties.Resources.disconnected;
                attachDatabaseToolStripMenuItem.Enabled = false;
            } else
            {
                this.DbConnectionLabel.Text = this.conn.DataSource;
                this.DbConnectionLabel.Image = Properties.Resources.connected;
                attachDatabaseToolStripMenuItem.Enabled = true;
            }
        }

        private void CreateDB()
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Create Database";
            theDialog.Filter = "SQLite DB Files|*.db";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string cs = "Data Source=" + theDialog.FileName;
                    this.conn = new SQLiteConnection(cs);
                    this.conn.Open();
                    this.CheckConnection();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Create Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Failed to connect just set it to closed.
            this.conn = null;
            this.CheckConnection();
            return;
        }

        private bool ConnectToDB()
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Sqlite Database";
            theDialog.Filter = "DB files|*.db";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string cs = "Data Source=" + theDialog.FileName;
                    this.conn = new SQLiteConnection(cs);
                    this.conn.Open();
                    this.CheckConnection();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQLite Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Failed to connect just set it to closed.
            this.conn = null;
            this.CheckConnection();
            return false;
        }

        private void RunQuery(string text)
        {
            if (this.conn == null) if (!this.ConnectToDB()) return;
            QueryStatusLabel.Text = "Running...";
            string timeLabel = "";
            this.Results = new DataTable();
            int changes = 0;
            int results = 0;
            long msTime = 0;
            long sTime = 0;

            string errorString = "";

            Stopwatch stopWatch = new Stopwatch();

            this.DbQueryProgress.Style = ProgressBarStyle.Marquee;
            this.DbQueryProgress.Value = 100;
            try
            {
                stopWatch.Start();
                var cmd = new SQLiteCommand(text, this.conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(this.Results);
                stopWatch.Stop();

                changes = this.conn.Changes;
                results = this.Results.Rows.Count;
                msTime = stopWatch.ElapsedMilliseconds;
            }
            catch (Exception ex)
            {
                this.Results = null;
                errorString = ex.Message.Replace("\r\n", " ");
                changes = 0;
                results = 0;
            }
            dataGridView1.DataSource = this.Results;

            if (msTime > 0)
            {
                if (msTime > 1000)
                {
                    sTime = msTime / 1000;
                    msTime -= sTime * 1000;
                    timeLabel = string.Format(" time ({0} s {1} ms)", sTime, msTime);
                }
                else
                {
                    timeLabel = string.Format(" time ({0} ms)", msTime);
                }
            }
            //long a_lastRow = this.conn.LastInsertRowId;
            SQLiteErrorCode a_code = this.conn.ResultCode();
            string status = a_code.ToString();
            if (a_code.Equals(SQLiteErrorCode.Ok))
            {
                this.QueryStatusLabel.Image = Properties.Resources.status_ok;
                if (this.Results.Columns.Count > 0)
                {
                    status += " Results : " + results.ToString();
                    if (this.Results.Rows.Count > 0)
                        this.QueryStatusLabel.Image = Properties.Resources.status_plus;
                }
                else
                {
                    if (changes > 0)
                    {
                        status += " Changes : " + changes.ToString();
                        this.QueryStatusLabel.Image = Properties.Resources.status_cycle;
                    }
                }
            }
            else
            {
                this.QueryStatusLabel.Image = Properties.Resources.status_error;
                status += errorString;
            }
            QueryStatusLabel.Text = status;



            // load data
            DbQueryTimeLabel.Text = timeLabel;
            this.DbQueryProgress.Value = 0;
            this.DbQueryProgress.Style = ProgressBarStyle.Blocks;
            dataGridView1.AutoResizeColumns();
        }

        private void RunScript(string text)
        {
            if (this.conn == null) if (!this.ConnectToDB()) return;
            string SqlText = "BEGIN;\n" + text + "\nEND;";
            QueryStatusLabel.Text = "Running...";
            this.Results = new DataTable();
            int changes = 0;
            SQLiteErrorCode a_code;

            SQLiteCommand cmd = new SQLiteCommand(SqlText, this.conn);
            try
            {

                changes = cmd.ExecuteNonQuery();
                a_code = this.conn.ResultCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Results = null;
                a_code = this.conn.ResultCode();
                this.conn.Cancel();
                cmd.CommandText = "END;";
                changes = cmd.ExecuteNonQuery();
                this.QueryStatusLabel.Image = Properties.Resources.status_error;
            }
            
            dataGridView1.DataSource = this.Results;

            string status = "Script " + a_code.ToString();
            if (a_code.Equals(SQLiteErrorCode.Ok))
            {
                this.QueryStatusLabel.Image = Properties.Resources.status_ok;
                if (changes > 0)
                {
                    status += " Changes : " + changes.ToString();
                    this.QueryStatusLabel.Image = Properties.Resources.status_cycle;
                }
            }
            else
            {
                this.QueryStatusLabel.Image = Properties.Resources.status_error;
                if (changes < 0)
                {
                    status += " Rolled Back :" + Math.Abs(changes).ToString();
                }
            }
            QueryStatusLabel.Text = status;
            // load data

        }

        private void LoadSQL()
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open SQL File";
            theDialog.Filter = "SQL files|*.sql";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TextReader reader = File.OpenText(theDialog.FileName);
                    simpleEditor1.Text = reader.ReadToEnd();
                    this.sql_filename = theDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveSQL()
        {
            if(this.sql_filename != null) {
                try  {
                    System.IO.File.WriteAllText(this.sql_filename, simpleEditor1.Text);
                    return;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "SQL Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                this.SaveSQLAs();
            }
        }
        
        private void SaveSQLAs()
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save SQL File";
            theDialog.Filter = "SQL Files|*.sql";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(theDialog.FileName, simpleEditor1.Text);
                    this.sql_filename = theDialog.FileName;
                    MessageBox.Show("File :" + theDialog.FileName, "SQL File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveJSON()
        {
            if (this.Results == null) return;

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            foreach (DataRow dr in this.Results.Rows)
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                foreach (DataColumn col in this.Results.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }

            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save JSON File";
            theDialog.Filter = "JSON Files|*.json";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string text = JsonConvert.SerializeObject(rows, Newtonsoft.Json.Formatting.Indented);
                    System.IO.File.WriteAllText(theDialog.FileName, text);
                    MessageBox.Show("File :" + theDialog.FileName, "JSON File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "JSON Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void SaveCSV()
        {
            if (this.Results == null) return;


            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save CSV File";
            theDialog.Filter = "CSV Files|*.csv";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string text = "";
                    foreach (DataColumn col in this.Results.Columns)
                    {
                        if (text.Length > 0)
                        {
                            text += "," + col.ColumnName;
                        }
                        else
                        {
                            text = col.ColumnName;
                        }
                    }
                    text += "\n";
                    foreach (DataRow dr in this.Results.Rows)
                    {
                        string line = "";
                        foreach (DataColumn col in this.Results.Columns)
                        {
                            if (line.Length > 0)
                            {
                                line += "," + dr[col].ToString();
                            }
                            else
                            {
                                line += dr[col].ToString();
                            }
                        }
                        text += line + "\n";
                    }

                    System.IO.File.WriteAllText(theDialog.FileName, text);
                    MessageBox.Show("File :" + theDialog.FileName, "CSV File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "CSV Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void CloseWindow()
        {
            if (this.is_root)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        // ============ call backs
        private void Close_Click(object sender, EventArgs e)
        {
            this.CloseWindow();
        }

        private void runSqlScript_Click(object sender, EventArgs e)
        {
            string sql = this.simpleEditor1.SelectedText;

            if (sql.Length > 0)
                this.RunScript(sql);
            else
                this.RunScript(this.simpleEditor1.Text);
        }

        private void editCopy_Click(object sender, EventArgs e)
        {
            this.simpleEditor1.Copy();
        }
        
        private void editCut_Click(object sender, EventArgs e)
        {
            this.simpleEditor1.Cut();
        }
        
        private void editPaste_Click(object sender, EventArgs e)
        {
            this.simpleEditor1.Paste();
        }
        
        private void editSelectAll_Click(object sender, EventArgs e)
        {
            this.simpleEditor1.SelectAll();
        }

        private void runSql_Click(object sender, EventArgs e)
        {
            string sql = this.simpleEditor1.SelectedText;

            if (sql.Length > 0)
                this.RunQuery(sql);
            else
                this.RunScript(this.simpleEditor1.Text);
        }

        private void newSql_Click(object sender, EventArgs e)
        {
            this.simpleEditor1.Text = "";
            this.sql_filename = null;

            return;
        }
 
        private void openSql_Click(object sender, EventArgs e)
        {
            this.LoadSQL();
        }

        private void saveSql_Click(object sender, EventArgs e)
        {
            this.SaveSQL();
        }

        private void saveSqlas_Click(object sender, EventArgs e)
        {
            this.SaveSQLAs();
        }

        private void saveCSV_Click(object sender, EventArgs e)
        {
            this.SaveCSV();
        }

        private void saveJSON_Click(object sender, EventArgs e)
        {
            this.SaveJSON();
        }

        private void openDatabase_Click(object sender, EventArgs e)
        {
            this.ConnectToDB();
        }
        
        private void attachDatabase_Click(object sender, EventArgs e)
        {
            WSAttachDBForm form = new WSAttachDBForm(this.conn);
            form.Show();
        }

        private void createDatabase_Click(object sender, EventArgs e)
        {
            this.CreateDB();
        }

        private void RunPragmaBtn_Click(object sender, EventArgs e)
        {
            string text = this.DbPragmaList.Text;
            if (text.Length > 0)
            {
                this.RunQuery("PRAGMA " + text);
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.simpleEditor1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.simpleEditor1.Redo();
        }
    }
}
