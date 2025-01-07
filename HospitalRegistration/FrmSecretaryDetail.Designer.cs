namespace HospitalRegistration
{
    partial class FrmSecretaryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCitID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rTxtAnnoun = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mTxtCitID = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.mTxtTime = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDate = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.btnAppList = new System.Windows.Forms.Button();
            this.btnDepPanel = new System.Windows.Forms.Button();
            this.btnDocPanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNameSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCitID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(459, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Info";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameSurname.Location = new System.Drawing.Point(235, 106);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(93, 23);
            this.lblNameSurname.TabIndex = 5;
            this.lblNameSurname.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name Surname:";
            // 
            // lblCitID
            // 
            this.lblCitID.AutoSize = true;
            this.lblCitID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCitID.Location = new System.Drawing.Point(235, 56);
            this.lblCitID.Name = "lblCitID";
            this.lblCitID.Size = new System.Drawing.Size(142, 23);
            this.lblCitID.TabIndex = 3;
            this.lblCitID.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Citizen ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.rTxtAnnoun);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(14, 202);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(459, 348);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Announcement";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(8, 278);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(443, 63);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rTxtAnnoun
            // 
            this.rTxtAnnoun.Location = new System.Drawing.Point(8, 33);
            this.rTxtAnnoun.Name = "rTxtAnnoun";
            this.rTxtAnnoun.Size = new System.Drawing.Size(443, 239);
            this.rTxtAnnoun.TabIndex = 4;
            this.rTxtAnnoun.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mTxtCitID);
            this.groupBox3.Controls.Add(this.cmbDoctor);
            this.groupBox3.Controls.Add(this.cmbDepartment);
            this.groupBox3.Controls.Add(this.mTxtTime);
            this.groupBox3.Controls.Add(this.mTxtDate);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.chkStatus);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(483, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(381, 537);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Panel";
            // 
            // mTxtCitID
            // 
            this.mTxtCitID.Location = new System.Drawing.Point(174, 282);
            this.mTxtCitID.Mask = "00000000000";
            this.mTxtCitID.Name = "mTxtCitID";
            this.mTxtCitID.Size = new System.Drawing.Size(199, 33);
            this.mTxtCitID.TabIndex = 19;
            this.mTxtCitID.ValidatingType = typeof(int);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(174, 231);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(199, 33);
            this.cmbDoctor.TabIndex = 18;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(174, 184);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(199, 33);
            this.cmbDepartment.TabIndex = 17;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // mTxtTime
            // 
            this.mTxtTime.Location = new System.Drawing.Point(174, 133);
            this.mTxtTime.Mask = "00:00";
            this.mTxtTime.Name = "mTxtTime";
            this.mTxtTime.Size = new System.Drawing.Size(199, 33);
            this.mTxtTime.TabIndex = 16;
            this.mTxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // mTxtDate
            // 
            this.mTxtDate.Location = new System.Drawing.Point(174, 83);
            this.mTxtDate.Mask = "00/00/0000";
            this.mTxtDate.Name = "mTxtDate";
            this.mTxtDate.Size = new System.Drawing.Size(199, 33);
            this.mTxtDate.TabIndex = 15;
            this.mTxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(174, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(199, 33);
            this.txtID.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 62);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(174, 330);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(98, 29);
            this.chkStatus.TabIndex = 0;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(56, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Citizen ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(85, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Doctor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(103, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(105, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(126, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(874, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Size = new System.Drawing.Size(411, 327);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Departments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(874, 348);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox5.Size = new System.Drawing.Size(411, 367);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(5, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(401, 333);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAnnouncements);
            this.groupBox6.Controls.Add(this.btnAppList);
            this.groupBox6.Controls.Add(this.btnDepPanel);
            this.groupBox6.Controls.Add(this.btnDocPanel);
            this.groupBox6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(14, 558);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox6.Size = new System.Drawing.Size(850, 157);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Quick Access";
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.Location = new System.Drawing.Point(652, 59);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(190, 56);
            this.btnAnnouncements.TabIndex = 17;
            this.btnAnnouncements.Text = "Announcements";
            this.btnAnnouncements.UseVisualStyleBackColor = true;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // btnAppList
            // 
            this.btnAppList.Location = new System.Drawing.Point(434, 59);
            this.btnAppList.Name = "btnAppList";
            this.btnAppList.Size = new System.Drawing.Size(212, 56);
            this.btnAppList.TabIndex = 16;
            this.btnAppList.Text = "Appointment List";
            this.btnAppList.UseVisualStyleBackColor = true;
            this.btnAppList.Click += new System.EventHandler(this.btnAppList_Click);
            // 
            // btnDepPanel
            // 
            this.btnDepPanel.Location = new System.Drawing.Point(210, 59);
            this.btnDepPanel.Name = "btnDepPanel";
            this.btnDepPanel.Size = new System.Drawing.Size(212, 56);
            this.btnDepPanel.TabIndex = 15;
            this.btnDepPanel.Text = "Department Panel";
            this.btnDepPanel.UseVisualStyleBackColor = true;
            this.btnDepPanel.Click += new System.EventHandler(this.btnDepPanel_Click);
            // 
            // btnDocPanel
            // 
            this.btnDocPanel.Location = new System.Drawing.Point(8, 59);
            this.btnDocPanel.Name = "btnDocPanel";
            this.btnDocPanel.Size = new System.Drawing.Size(196, 56);
            this.btnDocPanel.TabIndex = 14;
            this.btnDocPanel.Text = "Doctor Panel";
            this.btnDocPanel.UseVisualStyleBackColor = true;
            this.btnDocPanel.Click += new System.EventHandler(this.btnDocPanel_Click);
            // 
            // FrmSecretaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1299, 728);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmSecretaryDetail";
            this.Text = "Secretary Detail";
            this.Load += new System.EventHandler(this.FrmSecretaryDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCitID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RichTextBox rTxtAnnoun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.MaskedTextBox mTxtCitID;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.MaskedTextBox mTxtTime;
        private System.Windows.Forms.MaskedTextBox mTxtDate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAppList;
        private System.Windows.Forms.Button btnDepPanel;
        private System.Windows.Forms.Button btnDocPanel;
        private System.Windows.Forms.Button btnAnnouncements;
    }
}