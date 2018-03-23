namespace CallCenter
{
    partial class AssignProject
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.database1DataSet5 = new CallCenter.Database1DataSet5();
            this.pROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROSTableAdapter = new CallCenter.Database1DataSet5TableAdapters.PROSTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pROSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.database1DataSet6 = new CallCenter.Database1DataSet6();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new CallCenter.Database1DataSet6TableAdapters.usersTableAdapter();
            this.database1DataSet7 = new CallCenter.Database1DataSet7();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new CallCenter.Database1DataSet7TableAdapters.usersTableAdapter();
            this.buttonAssign = new MetroFramework.Controls.MetroButton();
            this.buttonBack = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(66, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Vacant Employees";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(66, 171);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Select Project";
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROSBindingSource
            // 
            this.pROSBindingSource.DataMember = "PROS";
            this.pROSBindingSource.DataSource = this.database1DataSet5;
            // 
            // pROSTableAdapter
            // 
            this.pROSTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pROSBindingSource1;
            this.comboBox1.DisplayMember = "pname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "pname";
            // 
            // pROSBindingSource1
            // 
            this.pROSBindingSource1.DataMember = "PROS";
            this.pROSBindingSource1.DataSource = this.database1DataSet5;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.usersBindingSource1;
            this.comboBox2.DisplayMember = "UNAME";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(249, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "UNAME";
            // 
            // database1DataSet6
            // 
            this.database1DataSet6.DataSetName = "Database1DataSet6";
            this.database1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.database1DataSet6;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet7
            // 
            this.database1DataSet7.DataSetName = "Database1DataSet7";
            this.database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.database1DataSet7;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(465, 129);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(75, 23);
            this.buttonAssign.TabIndex = 3;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseSelectable = true;
            this.buttonAssign.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAssign_MouseClick);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(465, 219);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseSelectable = true;
            this.buttonBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonBack_MouseClick);
            // 
            // AssignProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 283);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AssignProject";
            this.Text = "AssignProject";
            this.Load += new System.EventHandler(this.AssignProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource pROSBindingSource;
        private Database1DataSet5TableAdapters.PROSTableAdapter pROSTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource pROSBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Database1DataSet6 database1DataSet6;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database1DataSet6TableAdapters.usersTableAdapter usersTableAdapter;
        private Database1DataSet7 database1DataSet7;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private Database1DataSet7TableAdapters.usersTableAdapter usersTableAdapter1;
        private MetroFramework.Controls.MetroButton buttonAssign;
        private MetroFramework.Controls.MetroButton buttonBack;
    }
}