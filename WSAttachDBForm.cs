using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WolfSQL
{
    public partial class WSAttachDBForm : Form
    {
        private SQLiteConnection conn = null;

        public WSAttachDBForm(SQLiteConnection wRoot)
        {
            InitializeComponent();
            DbAttachButton.Enabled = false;
            this.conn = wRoot;
            this.Browse();
        }

        private void Browse()
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Sqlite Database";
            theDialog.Filter = "DB files|*.db";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DbFileName.Text = theDialog.FileName;
                    DbAttachButton.Enabled = true;
                    DbDBName.Text = Path.GetFileNameWithoutExtension(theDialog.FileName);
                    DbDBName.Focus();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQLite Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DbFileName.Text = "";
            DbAttachButton.Enabled = false;
        }

        private void AttachDB()
        {
            // Attach...
            string DB_Name = DbDBName.Text;
            string DB_File = DbFileName.Text;
            if (this.conn != null && DB_Name.Length > 0)
            {
                try
                {
                    SQLiteCommand cmd = this.conn.CreateCommand();
                    cmd.CommandText = "ATTACH DATABASE '" + DB_File + "' AS " + DB_Name + ";";
                    int ch = cmd.ExecuteNonQuery();
                    string line = "Attached database " + DB_Name;
                    MessageBox.Show(line, "Attached ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } 
                catch
                {
                    MessageBox.Show("Failed to attach database :"+DB_Name, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        // Event Callbacks

        private void button1_Click(object sender, EventArgs e)
        {
            this.Browse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AttachDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cancel
            this.Close();
        }

        private void DbDBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.AttachDB();
        }
    }
}
