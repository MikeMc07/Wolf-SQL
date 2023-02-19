using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyScintilla.Stylers;
using Newtonsoft.Json;
using System.Diagnostics;


/*
using (var connection = new SqliteConnection("Data Source=hello.db"))
{
    connection.Open();

    var command = connection.CreateCommand();
    command.CommandText =
    @"
        SELECT name
        FROM user
        WHERE id = $id
    ";
    command.Parameters.AddWithValue("$id", id);

    using (var reader = command.ExecuteReader())
    {
        while (reader.Read())
        {
            var name = reader.GetString(0);

            Console.WriteLine($"Hello, {name}!");
        }
    }
}
SQLiteDataReader rdr = cmd.ExecuteReader();
dataGridView1.Rows.Clear();
dataGridView1.Columns.Clear();
DataTable dt = new DataTable();
dt.Load(rdr); // <-- FormatException

for (int x = 0; x < rdr.FieldCount; x++)
{
    DataGridViewColumn col = new DataGridViewColumn();
    col.
    dataGridView1.Columns.Add()
}

while (rdr.Read())
{

    Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetInt32(2)}");
}
// object obj = cmd.ExecuteScalar();
*/

namespace WolfSQL
{
    public partial class SQLWindow : Form
    {
        private SQLiteConnection conn = null;
        private DataTable Results = null;
        private bool is_root = false;

        public SQLWindow(bool root=true)
        {
            InitializeComponent();
            this.simpleEditor1.Styler = new SqllisteStyler();
            this.is_root = root;
        }
        void CheckConnection()
        {
            if (this.conn == null || this.conn.State == ConnectionState.Closed)
            {
                this.dbStatusLabel.Text = "No DB";
                this.dbStatusLabel.Image = Properties.Resources.disconnected;
                this.attachDatabaseToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.dbStatusLabel.Text = this.conn.DataSource;
                this.dbStatusLabel.Image = Properties.Resources.connected;
                this.attachDatabaseToolStripMenuItem.Enabled = true;
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
                errorString = ex.Message.Replace("\r\n"," ");
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
            if ( a_code.Equals(SQLiteErrorCode.Ok) )
            {
                this.QueryStatusLabel.Image = Properties.Resources.status_ok;
                if (this.Results.Columns.Count > 0)
                {
                    status += " Results : " + results.ToString();
                    if ( this.Results.Rows.Count > 0 )
                        this.QueryStatusLabel.Image = Properties.Resources.status_plus;
                } else {
                    if (changes > 0) {
                        status += " Changes : " + changes.ToString();
                        this.QueryStatusLabel.Image = Properties.Resources.status_cycle;
                    }
                }
            } else {
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

            SQLiteCommand cmd = new SQLiteCommand(SqlText, this.conn);
            try {
                changes = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Results = null;
                changes = 0;
                this.QueryStatusLabel.Image = Properties.Resources.status_error;
            }
            dataGridView1.DataSource = this.Results;

            //long a_lastRow = this.conn.LastInsertRowId;
            SQLiteErrorCode a_code = this.conn.ResultCode();
            string status = "Script " + a_code.ToString();
            if (a_code.Equals(SQLiteErrorCode.Ok))
            {
                this.QueryStatusLabel.Image = Properties.Resources.status_ok;
                if (changes > 0)
                {
                    status += " Changes : " + changes.ToString();
                    this.QueryStatusLabel.Image = Properties.Resources.status_cycle;
                }
            } else {
                this.QueryStatusLabel.Image = Properties.Resources.status_error;
            }
            QueryStatusLabel.Text = status;
            // load data

        }

        void RunSelected()
        {
            string text = simpleEditor1.SelectedText;
            if (text.Length > 0)
            {
                this.RunQuery(text);
            }

        }
        void RunAll()
        {
            this.RunQuery(simpleEditor1.Text);
        }
        void Run()
        {
            // just run is based on if there is text selected.
            // if so run that otherwise run all the text..
            string text = simpleEditor1.SelectedText;
            if (text.Length > 0)
                this.RunQuery(text);
            else
                this.RunQuery(simpleEditor1.Text);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SaveSQL()
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save SQL File";
            theDialog.Filter = "SQL Files|*.sql";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(theDialog.FileName, simpleEditor1.Text);
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
                            if (line.Length > 0) {
                                line += "," + dr[col].ToString();
                            } else {
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

        private void ResizeWin()
        {
            Padding mar = splitContainer1.Margin;
            int width = splitContainer1.Panel2.Width - (mar.Left + mar.Right);
            int height = splitContainer1.Panel2.Height - (statusStrip1.Height + mar.Top + mar.Bottom);
            dataGridView1.Size = new Size(width, height);
        }

        private void CloseWindow()
        {
            if (this.is_root) {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }


        // Callbacks/Events.

        private void SQLWindow_Load(object sender, EventArgs e)
        {

            this.ResizeWin();
        }

        private void connectToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ConnectToDB();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseWindow();
        }

        private void SQLWindow_Resize(object sender, EventArgs e)
        {
            this.ResizeWin();
        }

        private void loadSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadSQL();
        }

        private void saveSQLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.SaveSQL();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            this.ResizeWin();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Run();
        }

        private void runAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RunAll();
        }

        private void runSelectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.RunSelected();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LoadSQL();
        }

        private void saveSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveSQL();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseWindow();
        }

        private void saveResultsAsJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveJSON();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            simpleEditor1.Copy();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            simpleEditor1.Cut();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            simpleEditor1.Paste();
        }

        private void runToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Run();

        }

        private void runAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.RunAll();
        }

        private void runSelectedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.RunSelected();
        }

        private void saveResultsAsCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveCSV();
        }

        private void runAsScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = simpleEditor1.SelectedText;
            if (text.Length == 0)
                text = simpleEditor1.Text;
            this.RunScript(text);
        }

        private void runScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = simpleEditor1.SelectedText;
            if (text.Length == 0)
                text = simpleEditor1.Text;
            this.RunScript(text);
        }

        private void createDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CreateDB();
        }
    }


}
