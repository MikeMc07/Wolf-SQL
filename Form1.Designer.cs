
namespace WolfSQL
{
    partial class Form1
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
            this.SQLWindowButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SQLWindowButton
            // 
            this.SQLWindowButton.Location = new System.Drawing.Point(12, 12);
            this.SQLWindowButton.Name = "SQLWindowButton";
            this.SQLWindowButton.Size = new System.Drawing.Size(118, 23);
            this.SQLWindowButton.TabIndex = 0;
            this.SQLWindowButton.Text = "SqlWindow";
            this.SQLWindowButton.UseVisualStyleBackColor = true;
            this.SQLWindowButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(12, 70);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(118, 23);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wolf SQL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 241);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.SQLWindowButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SQLWindowButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button button1;
    }
}

