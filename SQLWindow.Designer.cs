
namespace WolfSQL
{
    partial class SQLWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSQLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.saveResultsAsJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultsAsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runAllToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.runSelectedToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.runAsScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DbQueryProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.QueryStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.simpleEditor1 = new EasyScintilla.SimpleEditor();
            this.SQLEditMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.loadSQLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbStatusLabel = new System.Windows.Forms.ToolStripDropDownButton();
            this.createDatabaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.DbQueryTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SQLEditMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToDatabaseToolStripMenuItem,
            this.createDatabaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadSQLToolStripMenuItem,
            this.saveSQLToolStripMenuItem1,
            this.toolStripSeparator7,
            this.saveResultsAsJsonToolStripMenuItem,
            this.saveResultsAsCSVToolStripMenuItem,
            this.toolStripSeparator6,
            this.runToolStripMenuItem1,
            this.runAllToolStripMenuItem2,
            this.runSelectedToolStripMenuItem2,
            this.runAsScriptToolStripMenuItem,
            this.toolStripSeparator4,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToDatabaseToolStripMenuItem
            // 
            this.connectToDatabaseToolStripMenuItem.Name = "connectToDatabaseToolStripMenuItem";
            this.connectToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.connectToDatabaseToolStripMenuItem.Text = "Connect to Database";
            this.connectToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.connectToDatabaseToolStripMenuItem_Click);
            // 
            // createDatabaseToolStripMenuItem
            // 
            this.createDatabaseToolStripMenuItem.Name = "createDatabaseToolStripMenuItem";
            this.createDatabaseToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createDatabaseToolStripMenuItem.Text = "Create Database";
            this.createDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // loadSQLToolStripMenuItem
            // 
            this.loadSQLToolStripMenuItem.Name = "loadSQLToolStripMenuItem";
            this.loadSQLToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.loadSQLToolStripMenuItem.Text = "Load SQL";
            this.loadSQLToolStripMenuItem.Click += new System.EventHandler(this.loadSQLToolStripMenuItem_Click);
            // 
            // saveSQLToolStripMenuItem1
            // 
            this.saveSQLToolStripMenuItem1.Name = "saveSQLToolStripMenuItem1";
            this.saveSQLToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.saveSQLToolStripMenuItem1.Text = "Save SQL";
            this.saveSQLToolStripMenuItem1.Click += new System.EventHandler(this.saveSQLToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(181, 6);
            // 
            // saveResultsAsJsonToolStripMenuItem
            // 
            this.saveResultsAsJsonToolStripMenuItem.Name = "saveResultsAsJsonToolStripMenuItem";
            this.saveResultsAsJsonToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveResultsAsJsonToolStripMenuItem.Text = "Save Results as JSON";
            this.saveResultsAsJsonToolStripMenuItem.Click += new System.EventHandler(this.saveResultsAsJsonToolStripMenuItem_Click);
            // 
            // saveResultsAsCSVToolStripMenuItem
            // 
            this.saveResultsAsCSVToolStripMenuItem.Name = "saveResultsAsCSVToolStripMenuItem";
            this.saveResultsAsCSVToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveResultsAsCSVToolStripMenuItem.Text = "Save Results as CSV";
            this.saveResultsAsCSVToolStripMenuItem.Click += new System.EventHandler(this.saveResultsAsCSVToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(181, 6);
            // 
            // runToolStripMenuItem1
            // 
            this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            this.runToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.runToolStripMenuItem1.Text = "Run";
            this.runToolStripMenuItem1.Click += new System.EventHandler(this.runToolStripMenuItem1_Click);
            // 
            // runAllToolStripMenuItem2
            // 
            this.runAllToolStripMenuItem2.Name = "runAllToolStripMenuItem2";
            this.runAllToolStripMenuItem2.Size = new System.Drawing.Size(184, 22);
            this.runAllToolStripMenuItem2.Text = "Run All";
            this.runAllToolStripMenuItem2.Click += new System.EventHandler(this.runAllToolStripMenuItem2_Click);
            // 
            // runSelectedToolStripMenuItem2
            // 
            this.runSelectedToolStripMenuItem2.Name = "runSelectedToolStripMenuItem2";
            this.runSelectedToolStripMenuItem2.Size = new System.Drawing.Size(184, 22);
            this.runSelectedToolStripMenuItem2.Text = "Run Selected";
            this.runSelectedToolStripMenuItem2.Click += new System.EventHandler(this.runSelectedToolStripMenuItem2_Click);
            // 
            // runAsScriptToolStripMenuItem
            // 
            this.runAsScriptToolStripMenuItem.Name = "runAsScriptToolStripMenuItem";
            this.runAsScriptToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.runAsScriptToolStripMenuItem.Text = "Run as Script";
            this.runAsScriptToolStripMenuItem.Click += new System.EventHandler(this.runAsScriptToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.quitToolStripMenuItem.Text = "Close";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(725, 401);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(725, 426);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbStatusLabel,
            this.DbQueryProgress,
            this.toolStripStatusLabel1,
            this.QueryStatusLabel,
            this.DbQueryTimeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(725, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DbQueryProgress
            // 
            this.DbQueryProgress.Name = "DbQueryProgress";
            this.DbQueryProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Text = "resultsStatusIcon";
            // 
            // QueryStatusLabel
            // 
            this.QueryStatusLabel.Image = global::WolfSQL.Properties.Resources.status_error;
            this.QueryStatusLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.QueryStatusLabel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.QueryStatusLabel.Name = "QueryStatusLabel";
            this.QueryStatusLabel.Size = new System.Drawing.Size(104, 17);
            this.QueryStatusLabel.Text = "Not Connected";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.simpleEditor1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(725, 401);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // simpleEditor1
            // 
            this.simpleEditor1.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.simpleEditor1.ContextMenuStrip = this.SQLEditMenu;
            this.simpleEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleEditor1.EolMode = ScintillaNET.Eol.Lf;
            this.simpleEditor1.IndentationGuides = ScintillaNET.IndentView.LookBoth;
            this.simpleEditor1.Lexer = ScintillaNET.Lexer.Sql;
            this.simpleEditor1.Location = new System.Drawing.Point(0, 0);
            this.simpleEditor1.Name = "simpleEditor1";
            this.simpleEditor1.Size = new System.Drawing.Size(725, 132);
            this.simpleEditor1.Styler = null;
            this.simpleEditor1.TabIndex = 0;
            this.simpleEditor1.Text = "select * from sqlite_master;";
            this.simpleEditor1.WrapMode = ScintillaNET.WrapMode.Word;
            // 
            // SQLEditMenu
            // 
            this.SQLEditMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.runAllToolStripMenuItem,
            this.runSelectedToolStripMenuItem1,
            this.runScriptToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripSeparator5,
            this.loadSQLToolStripMenuItem1,
            this.saveSQLToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem});
            this.SQLEditMenu.Name = "SQLEditMenu";
            this.SQLEditMenu.Size = new System.Drawing.Size(146, 242);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // runAllToolStripMenuItem
            // 
            this.runAllToolStripMenuItem.Name = "runAllToolStripMenuItem";
            this.runAllToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.runAllToolStripMenuItem.Text = "Run All";
            this.runAllToolStripMenuItem.Click += new System.EventHandler(this.runAllToolStripMenuItem_Click);
            // 
            // runSelectedToolStripMenuItem1
            // 
            this.runSelectedToolStripMenuItem1.Name = "runSelectedToolStripMenuItem1";
            this.runSelectedToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.runSelectedToolStripMenuItem1.Text = "Run Selected";
            this.runSelectedToolStripMenuItem1.Click += new System.EventHandler(this.runSelectedToolStripMenuItem1_Click);
            // 
            // runScriptToolStripMenuItem
            // 
            this.runScriptToolStripMenuItem.Name = "runScriptToolStripMenuItem";
            this.runScriptToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.runScriptToolStripMenuItem.Text = "Run Script";
            this.runScriptToolStripMenuItem.Click += new System.EventHandler(this.runScriptToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem2.Text = "Copy";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem3.Text = "Cut";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem4.Text = "Paste";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(142, 6);
            // 
            // loadSQLToolStripMenuItem1
            // 
            this.loadSQLToolStripMenuItem1.Name = "loadSQLToolStripMenuItem1";
            this.loadSQLToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.loadSQLToolStripMenuItem1.Text = "Load SQL File";
            this.loadSQLToolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // saveSQLToolStripMenuItem
            // 
            this.saveSQLToolStripMenuItem.Name = "saveSQLToolStripMenuItem";
            this.saveSQLToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveSQLToolStripMenuItem.Text = "Save SQL";
            this.saveSQLToolStripMenuItem.Click += new System.EventHandler(this.saveSQLToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(142, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(679, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbStatusLabel
            // 
            this.dbStatusLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attachDatabaseToolStripMenuItem,
            this.toolStripSeparator8,
            this.createDatabaseToolStripMenuItem1,
            this.openDatabaseToolStripMenuItem});
            this.dbStatusLabel.Image = global::WolfSQL.Properties.Resources.disconnected;
            this.dbStatusLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dbStatusLabel.Name = "dbStatusLabel";
            this.dbStatusLabel.Size = new System.Drawing.Size(70, 20);
            this.dbStatusLabel.Text = "No DB";
            // 
            // createDatabaseToolStripMenuItem1
            // 
            this.createDatabaseToolStripMenuItem1.Name = "createDatabaseToolStripMenuItem1";
            this.createDatabaseToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.createDatabaseToolStripMenuItem1.Text = "Create Database";
            this.createDatabaseToolStripMenuItem1.Click += new System.EventHandler(this.createDatabaseToolStripMenuItem_Click);
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openDatabaseToolStripMenuItem.Text = "Open Database";
            this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.connectToDatabaseToolStripMenuItem_Click);
            // 
            // attachDatabaseToolStripMenuItem
            // 
            this.attachDatabaseToolStripMenuItem.Enabled = false;
            this.attachDatabaseToolStripMenuItem.Name = "attachDatabaseToolStripMenuItem";
            this.attachDatabaseToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.attachDatabaseToolStripMenuItem.Text = "Attach Database";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(226, 6);
            // 
            // DbQueryTimeLabel
            // 
            this.DbQueryTimeLabel.Name = "DbQueryTimeLabel";
            this.DbQueryTimeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // SQLWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SQLWindow";
            this.Text = "SQLWindow";
            this.Load += new System.EventHandler(this.SQLWindow_Load);
            this.Resize += new System.EventHandler(this.SQLWindow_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.SQLEditMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EasyScintilla.SimpleEditor simpleEditor1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar DbQueryProgress;
        private System.Windows.Forms.ContextMenuStrip SQLEditMenu;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem loadSQLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel QueryStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem loadSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSQLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem runSelectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem saveResultsAsJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem runAllToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem runSelectedToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveResultsAsCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAsScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripDropDownButton dbStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem attachDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel DbQueryTimeLabel;
    }
}