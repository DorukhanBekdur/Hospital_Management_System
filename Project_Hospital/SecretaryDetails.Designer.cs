namespace Project_Hospital
{
    partial class FrmSecretaryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCreateAnouncement = new System.Windows.Forms.Button();
            this.RchAnouncement = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ChkStatus = new System.Windows.Forms.CheckBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.CmbExpertise = new System.Windows.Forms.ComboBox();
            this.MskTime = new System.Windows.Forms.MaskedTextBox();
            this.MskDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnAppointmentList = new System.Windows.Forms.Button();
            this.BtnExpertisePanel = new System.Windows.Forms.Button();
            this.BtnDoctorPanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(162, 98);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(76, 23);
            this.LblNameSurname.TabIndex = 4;
            this.LblNameSurname.Text = "Null Null";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(103, 52);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 23);
            this.LblTC.TabIndex = 3;
            this.LblTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC NO :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCreateAnouncement);
            this.groupBox2.Controls.Add(this.RchAnouncement);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create An Anouncement";
            // 
            // BtnCreateAnouncement
            // 
            this.BtnCreateAnouncement.Location = new System.Drawing.Point(6, 217);
            this.BtnCreateAnouncement.Name = "BtnCreateAnouncement";
            this.BtnCreateAnouncement.Size = new System.Drawing.Size(308, 58);
            this.BtnCreateAnouncement.TabIndex = 1;
            this.BtnCreateAnouncement.Text = "Create";
            this.BtnCreateAnouncement.UseVisualStyleBackColor = true;
            this.BtnCreateAnouncement.Click += new System.EventHandler(this.BtnCreateAnouncement_Click);
            // 
            // RchAnouncement
            // 
            this.RchAnouncement.Location = new System.Drawing.Point(6, 30);
            this.RchAnouncement.Name = "RchAnouncement";
            this.RchAnouncement.Size = new System.Drawing.Size(308, 181);
            this.RchAnouncement.TabIndex = 0;
            this.RchAnouncement.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Controls.Add(this.ChkStatus);
            this.groupBox3.Controls.Add(this.MskTC);
            this.groupBox3.Controls.Add(this.CmbDoctor);
            this.groupBox3.Controls.Add(this.CmbExpertise);
            this.groupBox3.Controls.Add(this.MskTime);
            this.groupBox3.Controls.Add(this.MskDate);
            this.groupBox3.Controls.Add(this.TxtID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(338, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 448);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Panel";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(151, 377);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(109, 45);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ChkStatus
            // 
            this.ChkStatus.AutoSize = true;
            this.ChkStatus.Location = new System.Drawing.Point(120, 333);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(80, 27);
            this.ChkStatus.TabIndex = 18;
            this.ChkStatus.Text = "Status";
            this.ChkStatus.UseVisualStyleBackColor = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(120, 296);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(177, 31);
            this.MskTC.TabIndex = 17;
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(120, 248);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(177, 31);
            this.CmbDoctor.TabIndex = 16;
            // 
            // CmbExpertise
            // 
            this.CmbExpertise.FormattingEnabled = true;
            this.CmbExpertise.Location = new System.Drawing.Point(120, 202);
            this.CmbExpertise.Name = "CmbExpertise";
            this.CmbExpertise.Size = new System.Drawing.Size(177, 31);
            this.CmbExpertise.TabIndex = 15;
            this.CmbExpertise.SelectedIndexChanged += new System.EventHandler(this.CmbExpertise_SelectedIndexChanged);
            // 
            // MskTime
            // 
            this.MskTime.Location = new System.Drawing.Point(120, 151);
            this.MskTime.Mask = "00:00";
            this.MskTime.Name = "MskTime";
            this.MskTime.Size = new System.Drawing.Size(177, 31);
            this.MskTime.TabIndex = 14;
            this.MskTime.ValidatingType = typeof(System.DateTime);
            // 
            // MskDate
            // 
            this.MskDate.Location = new System.Drawing.Point(120, 98);
            this.MskDate.Mask = "00/00/0000";
            this.MskDate.Name = "MskDate";
            this.MskDate.Size = new System.Drawing.Size(177, 31);
            this.MskDate.TabIndex = 13;
            this.MskDate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(120, 49);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(177, 31);
            this.TxtID.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Patient TC :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Doctor :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Expertise :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Time :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(676, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(578, 303);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Expertises";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(679, 321);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(578, 357);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(572, 327);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.BtnAppointmentList);
            this.groupBox6.Controls.Add(this.BtnExpertisePanel);
            this.groupBox6.Controls.Add(this.BtnDoctorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 466);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(658, 212);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fast Access";
            // 
            // BtnAppointmentList
            // 
            this.BtnAppointmentList.Location = new System.Drawing.Point(345, 57);
            this.BtnAppointmentList.Name = "BtnAppointmentList";
            this.BtnAppointmentList.Size = new System.Drawing.Size(144, 107);
            this.BtnAppointmentList.TabIndex = 2;
            this.BtnAppointmentList.Text = "Appointment List";
            this.BtnAppointmentList.UseVisualStyleBackColor = true;
            this.BtnAppointmentList.Click += new System.EventHandler(this.BtnAppointmentList_Click);
            // 
            // BtnExpertisePanel
            // 
            this.BtnExpertisePanel.Location = new System.Drawing.Point(176, 57);
            this.BtnExpertisePanel.Name = "BtnExpertisePanel";
            this.BtnExpertisePanel.Size = new System.Drawing.Size(144, 107);
            this.BtnExpertisePanel.TabIndex = 1;
            this.BtnExpertisePanel.Text = "Expertise Panel";
            this.BtnExpertisePanel.UseVisualStyleBackColor = true;
            this.BtnExpertisePanel.Click += new System.EventHandler(this.BtnExpertisePanel_Click);
            // 
            // BtnDoctorPanel
            // 
            this.BtnDoctorPanel.Location = new System.Drawing.Point(6, 57);
            this.BtnDoctorPanel.Name = "BtnDoctorPanel";
            this.BtnDoctorPanel.Size = new System.Drawing.Size(144, 107);
            this.BtnDoctorPanel.TabIndex = 0;
            this.BtnDoctorPanel.Text = "Doctor Panel";
            this.BtnDoctorPanel.UseVisualStyleBackColor = true;
            this.BtnDoctorPanel.Click += new System.EventHandler(this.BtnDoctorPanel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 107);
            this.button1.TabIndex = 3;
            this.button1.Text = "Anouncement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSecretaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1267, 690);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSecretaryDetails";
            this.Text = "Secretary Details";
            this.Load += new System.EventHandler(this.FrmSecretaryDetails_Load);
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
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCreateAnouncement;
        private System.Windows.Forms.RichTextBox RchAnouncement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CmbExpertise;
        private System.Windows.Forms.MaskedTextBox MskTime;
        private System.Windows.Forms.MaskedTextBox MskDate;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckBox ChkStatus;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnDoctorPanel;
        private System.Windows.Forms.Button BtnAppointmentList;
        private System.Windows.Forms.Button BtnExpertisePanel;
        private System.Windows.Forms.Button button1;
    }
}