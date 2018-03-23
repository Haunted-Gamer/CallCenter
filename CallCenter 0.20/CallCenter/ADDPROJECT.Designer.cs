namespace CallCenter
{
    partial class ADDPROJECT
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.labelUserName = new MetroFramework.Controls.MetroLabel();
            this.textBoxProjectName = new MetroFramework.Controls.MetroTextBox();
            this.textBoxProjectTime = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(444, 314);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(93, 34);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Back";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroLabel5_Click);
            this.metroButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroButton1_MouseClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 148);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Project Name";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(38, 194);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(149, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Project Time (in Minute)";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(38, 78);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "Your Username";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(211, 78);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(49, 19);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "uname";
            // 
            // textBoxProjectName
            // 
            // 
            // 
            // 
            this.textBoxProjectName.CustomButton.Image = null;
            this.textBoxProjectName.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.textBoxProjectName.CustomButton.Name = "";
            this.textBoxProjectName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxProjectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxProjectName.CustomButton.TabIndex = 1;
            this.textBoxProjectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxProjectName.CustomButton.UseSelectable = true;
            this.textBoxProjectName.CustomButton.Visible = false;
            this.textBoxProjectName.Lines = new string[0];
            this.textBoxProjectName.Location = new System.Drawing.Point(211, 148);
            this.textBoxProjectName.MaxLength = 32767;
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.PasswordChar = '\0';
            this.textBoxProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxProjectName.SelectedText = "";
            this.textBoxProjectName.SelectionLength = 0;
            this.textBoxProjectName.SelectionStart = 0;
            this.textBoxProjectName.ShortcutsEnabled = true;
            this.textBoxProjectName.Size = new System.Drawing.Size(171, 23);
            this.textBoxProjectName.TabIndex = 2;
            this.textBoxProjectName.UseSelectable = true;
            this.textBoxProjectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxProjectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxProjectTime
            // 
            // 
            // 
            // 
            this.textBoxProjectTime.CustomButton.Image = null;
            this.textBoxProjectTime.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.textBoxProjectTime.CustomButton.Name = "";
            this.textBoxProjectTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxProjectTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxProjectTime.CustomButton.TabIndex = 1;
            this.textBoxProjectTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxProjectTime.CustomButton.UseSelectable = true;
            this.textBoxProjectTime.CustomButton.Visible = false;
            this.textBoxProjectTime.Lines = new string[0];
            this.textBoxProjectTime.Location = new System.Drawing.Point(211, 194);
            this.textBoxProjectTime.MaxLength = 32767;
            this.textBoxProjectTime.Name = "textBoxProjectTime";
            this.textBoxProjectTime.PasswordChar = '\0';
            this.textBoxProjectTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxProjectTime.SelectedText = "";
            this.textBoxProjectTime.SelectionLength = 0;
            this.textBoxProjectTime.SelectionStart = 0;
            this.textBoxProjectTime.ShortcutsEnabled = true;
            this.textBoxProjectTime.Size = new System.Drawing.Size(171, 23);
            this.textBoxProjectTime.TabIndex = 2;
            this.textBoxProjectTime.UseSelectable = true;
            this.textBoxProjectTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxProjectTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(444, 189);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(93, 28);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Submit";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroButton2_MouseClick);
            // 
            // ADDPROJECT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 371);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.textBoxProjectTime);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton1);
            this.Name = "ADDPROJECT";
            this.Text = "ADDPROJECT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel labelUserName;
        private MetroFramework.Controls.MetroTextBox textBoxProjectName;
        private MetroFramework.Controls.MetroTextBox textBoxProjectTime;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}