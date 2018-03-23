namespace CallCenter
{
    partial class AdminPanelUI
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
            this.buttonAssignProject = new MetroFramework.Controls.MetroButton();
            this.tileRecorded = new MetroFramework.Controls.MetroTile();
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.tileChat = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.tileViewProfile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // buttonAssignProject
            // 
            this.buttonAssignProject.Location = new System.Drawing.Point(498, 46);
            this.buttonAssignProject.Name = "buttonAssignProject";
            this.buttonAssignProject.Size = new System.Drawing.Size(122, 23);
            this.buttonAssignProject.TabIndex = 6;
            this.buttonAssignProject.Text = "ASSIGN PROJECT";
            this.buttonAssignProject.UseSelectable = true;
            this.buttonAssignProject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroButton1_MouseClick);
            // 
            // tileRecorded
            // 
            this.tileRecorded.ActiveControl = null;
            this.tileRecorded.Location = new System.Drawing.Point(429, 75);
            this.tileRecorded.Name = "tileRecorded";
            this.tileRecorded.Size = new System.Drawing.Size(191, 120);
            this.tileRecorded.TabIndex = 5;
            this.tileRecorded.Text = "Recorded Conversations";
            this.tileRecorded.TileImage = global::CallCenter.Properties.Resources.appbar_microphone;
            this.tileRecorded.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileRecorded.UseSelectable = true;
            this.tileRecorded.UseTileImage = true;
            this.tileRecorded.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tileRecorded_MouseClick);
            // 
            // tileLogout
            // 
            this.tileLogout.ActiveControl = null;
            this.tileLogout.Location = new System.Drawing.Point(428, 222);
            this.tileLogout.Name = "tileLogout";
            this.tileLogout.Size = new System.Drawing.Size(192, 123);
            this.tileLogout.TabIndex = 4;
            this.tileLogout.Text = "Logout";
            this.tileLogout.TileImage = global::CallCenter.Properties.Resources.appbar_door_leave;
            this.tileLogout.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileLogout.UseSelectable = true;
            this.tileLogout.UseTileImage = true;
            this.tileLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tileLogout_MouseClick);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(227, 222);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(195, 123);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "View Reports";
            this.metroTile4.TileImage = global::CallCenter.Properties.Resources.appbar_page_multiple;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTile4_MouseClick);
            // 
            // tileChat
            // 
            this.tileChat.ActiveControl = null;
            this.tileChat.Location = new System.Drawing.Point(227, 75);
            this.tileChat.Name = "tileChat";
            this.tileChat.Size = new System.Drawing.Size(195, 120);
            this.tileChat.TabIndex = 2;
            this.tileChat.Text = "Chat ";
            this.tileChat.TileImage = global::CallCenter.Properties.Resources.appbar_chat;
            this.tileChat.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileChat.UseSelectable = true;
            this.tileChat.UseTileImage = true;
            this.tileChat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tileChat_MouseClick);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(24, 222);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(197, 123);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "View User List";
            this.metroTile2.TileImage = global::CallCenter.Properties.Resources.appbar_people_profile;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            this.metroTile2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTile2_MouseClick);
            // 
            // tileViewProfile
            // 
            this.tileViewProfile.ActiveControl = null;
            this.tileViewProfile.Location = new System.Drawing.Point(24, 75);
            this.tileViewProfile.Name = "tileViewProfile";
            this.tileViewProfile.Size = new System.Drawing.Size(197, 120);
            this.tileViewProfile.TabIndex = 0;
            this.tileViewProfile.Text = "View Profile";
            this.tileViewProfile.TileImage = global::CallCenter.Properties.Resources.appbar_people;
            this.tileViewProfile.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileViewProfile.UseSelectable = true;
            this.tileViewProfile.UseTileImage = true;
            this.tileViewProfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tileViewProfile_MouseClick);
            // 
            // AdminPanelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 386);
            this.Controls.Add(this.buttonAssignProject);
            this.Controls.Add(this.tileRecorded);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.tileChat);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.tileViewProfile);
            this.Name = "AdminPanelUI";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileViewProfile;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile tileChat;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile tileLogout;
        private MetroFramework.Controls.MetroTile tileRecorded;
        private MetroFramework.Controls.MetroButton buttonAssignProject;
    }
}