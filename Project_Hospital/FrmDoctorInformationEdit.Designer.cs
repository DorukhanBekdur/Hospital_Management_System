namespace Project_Hospital
{
    partial class FrmDoctorInformationEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorInformationEdit));
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbExpertise = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnInformationUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(143, 49);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(130, 31);
            this.TxtSurname.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Surname :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(143, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(130, 31);
            this.TxtName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name :";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(143, 86);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(130, 31);
            this.MskTC.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "TC Identity Id :";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(143, 162);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(130, 31);
            this.TxtPassword.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Password :";
            // 
            // CmbExpertise
            // 
            this.CmbExpertise.FormattingEnabled = true;
            this.CmbExpertise.Location = new System.Drawing.Point(143, 125);
            this.CmbExpertise.Name = "CmbExpertise";
            this.CmbExpertise.Size = new System.Drawing.Size(130, 31);
            this.CmbExpertise.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Expertise :";
            // 
            // BtnInformationUpdate
            // 
            this.BtnInformationUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnInformationUpdate.Location = new System.Drawing.Point(143, 199);
            this.BtnInformationUpdate.Name = "BtnInformationUpdate";
            this.BtnInformationUpdate.Size = new System.Drawing.Size(130, 42);
            this.BtnInformationUpdate.TabIndex = 37;
            this.BtnInformationUpdate.Text = "Update";
            this.BtnInformationUpdate.UseVisualStyleBackColor = false;
            this.BtnInformationUpdate.Click += new System.EventHandler(this.BtnInformationUpdate_Click);
            // 
            // FrmDoctorInformationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(338, 251);
            this.Controls.Add(this.BtnInformationUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbExpertise);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorInformationEdit";
            this.Text = "Doctor Information Edit Panel";
            this.Load += new System.EventHandler(this.FrmDoctorInformationEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbExpertise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnInformationUpdate;
    }
}