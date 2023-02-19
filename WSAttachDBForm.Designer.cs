
namespace WolfSQL
{
    partial class WSAttachDBForm
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
            this.DbFileName = new System.Windows.Forms.TextBox();
            this.DbDBName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DbAttachButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DbFileName
            // 
            this.DbFileName.Location = new System.Drawing.Point(12, 25);
            this.DbFileName.Name = "DbFileName";
            this.DbFileName.ReadOnly = true;
            this.DbFileName.Size = new System.Drawing.Size(228, 20);
            this.DbFileName.TabIndex = 0;
            // 
            // DbDBName
            // 
            this.DbDBName.Location = new System.Drawing.Point(12, 76);
            this.DbDBName.Name = "DbDBName";
            this.DbDBName.Size = new System.Drawing.Size(147, 20);
            this.DbDBName.TabIndex = 1;
            this.DbDBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DbDBName_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Attach as";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database File";
            // 
            // DbAttachButton
            // 
            this.DbAttachButton.Location = new System.Drawing.Point(246, 74);
            this.DbAttachButton.Name = "DbAttachButton";
            this.DbAttachButton.Size = new System.Drawing.Size(75, 23);
            this.DbAttachButton.TabIndex = 5;
            this.DbAttachButton.Text = "Attach";
            this.DbAttachButton.UseVisualStyleBackColor = true;
            this.DbAttachButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // WSAttachDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 109);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DbAttachButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DbDBName);
            this.Controls.Add(this.DbFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WSAttachDBForm";
            this.Text = "Attach Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DbFileName;
        private System.Windows.Forms.TextBox DbDBName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DbAttachButton;
        private System.Windows.Forms.Button button3;
    }
}