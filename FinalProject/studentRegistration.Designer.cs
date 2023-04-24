namespace FinalProject
{
    partial class studentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentRegistration));
            this.lblSkillsInternational = new System.Windows.Forms.Label();
            this.gbStudentRegistration = new System.Windows.Forms.GroupBox();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gbParentDetails = new System.Windows.Forms.GroupBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblParentName = new System.Windows.Forms.Label();
            this.gbContactDetails = new System.Windows.Forms.GroupBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gbBasicDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.linklblLogout = new System.Windows.Forms.LinkLabel();
            this.linklblExit = new System.Windows.Forms.LinkLabel();
            this.errorProviderHphone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderParentName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNIC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContactNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbStudentRegistration.SuspendLayout();
            this.gbParentDetails.SuspendLayout();
            this.gbContactDetails.SuspendLayout();
            this.gbBasicDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkillsInternational
            // 
            this.lblSkillsInternational.AutoSize = true;
            this.lblSkillsInternational.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillsInternational.ForeColor = System.Drawing.Color.Black;
            this.lblSkillsInternational.Location = new System.Drawing.Point(192, 18);
            this.lblSkillsInternational.Name = "lblSkillsInternational";
            this.lblSkillsInternational.Size = new System.Drawing.Size(231, 28);
            this.lblSkillsInternational.TabIndex = 0;
            this.lblSkillsInternational.Text = "Skills International";
            // 
            // gbStudentRegistration
            // 
            this.gbStudentRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbStudentRegistration.Controls.Add(this.btnViewStudents);
            this.gbStudentRegistration.Controls.Add(this.btnDelete);
            this.gbStudentRegistration.Controls.Add(this.btnClear);
            this.gbStudentRegistration.Controls.Add(this.btnUpdate);
            this.gbStudentRegistration.Controls.Add(this.btnRegister);
            this.gbStudentRegistration.Controls.Add(this.gbParentDetails);
            this.gbStudentRegistration.Controls.Add(this.gbContactDetails);
            this.gbStudentRegistration.Controls.Add(this.gbBasicDetails);
            this.gbStudentRegistration.Controls.Add(this.lblRegNo);
            this.gbStudentRegistration.Controls.Add(this.cmbRegNo);
            this.gbStudentRegistration.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentRegistration.Location = new System.Drawing.Point(27, 50);
            this.gbStudentRegistration.Name = "gbStudentRegistration";
            this.gbStudentRegistration.Size = new System.Drawing.Size(553, 584);
            this.gbStudentRegistration.TabIndex = 2;
            this.gbStudentRegistration.TabStop = false;
            this.gbStudentRegistration.Text = "Student Registration";
            this.gbStudentRegistration.Enter += new System.EventHandler(this.gbStudentRegistration_Enter);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudents.Location = new System.Drawing.Point(430, 32);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(104, 26);
            this.btnViewStudents.TabIndex = 10;
            this.btnViewStudents.Text = "View ";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(445, 558);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 26);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(364, 558);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 26);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(99, 558);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(18, 558);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 26);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // gbParentDetails
            // 
            this.gbParentDetails.Controls.Add(this.txtContactNumber);
            this.gbParentDetails.Controls.Add(this.txtNIC);
            this.gbParentDetails.Controls.Add(this.txtParentName);
            this.gbParentDetails.Controls.Add(this.lblContactNumber);
            this.gbParentDetails.Controls.Add(this.lblNIC);
            this.gbParentDetails.Controls.Add(this.lblParentName);
            this.gbParentDetails.Location = new System.Drawing.Point(18, 408);
            this.gbParentDetails.Name = "gbParentDetails";
            this.gbParentDetails.Size = new System.Drawing.Size(515, 144);
            this.gbParentDetails.TabIndex = 3;
            this.gbParentDetails.TabStop = false;
            this.gbParentDetails.Text = "Parent Details";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(139, 94);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(158, 26);
            this.txtContactNumber.TabIndex = 13;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(139, 62);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(158, 26);
            this.txtNIC.TabIndex = 12;
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(139, 28);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(350, 26);
            this.txtParentName.TabIndex = 11;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(20, 97);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(111, 19);
            this.lblContactNumber.TabIndex = 10;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(20, 64);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(32, 19);
            this.lblNIC.TabIndex = 9;
            this.lblNIC.Text = "NIC";
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(20, 31);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(89, 19);
            this.lblParentName.TabIndex = 8;
            this.lblParentName.Text = "Parent Name";
            // 
            // gbContactDetails
            // 
            this.gbContactDetails.Controls.Add(this.txtHomePhone);
            this.gbContactDetails.Controls.Add(this.txtMobilePhone);
            this.gbContactDetails.Controls.Add(this.txtEmail);
            this.gbContactDetails.Controls.Add(this.txtAddress);
            this.gbContactDetails.Controls.Add(this.lblHomePhone);
            this.gbContactDetails.Controls.Add(this.lblMobilePhone);
            this.gbContactDetails.Controls.Add(this.lblEmail);
            this.gbContactDetails.Controls.Add(this.lblAddress);
            this.gbContactDetails.Location = new System.Drawing.Point(18, 235);
            this.gbContactDetails.Name = "gbContactDetails";
            this.gbContactDetails.Size = new System.Drawing.Size(515, 167);
            this.gbContactDetails.TabIndex = 2;
            this.gbContactDetails.TabStop = false;
            this.gbContactDetails.Text = "Contact Details";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(380, 127);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(110, 26);
            this.txtHomePhone.TabIndex = 11;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(139, 127);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(110, 26);
            this.txtMobilePhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(139, 24);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(350, 56);
            this.txtAddress.TabIndex = 8;
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(278, 129);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(89, 19);
            this.lblHomePhone.TabIndex = 7;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(20, 130);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new System.Drawing.Size(94, 19);
            this.lblMobilePhone.TabIndex = 6;
            this.lblMobilePhone.Text = "Mobile Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 26);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 19);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // gbBasicDetails
            // 
            this.gbBasicDetails.Controls.Add(this.dtpDOB);
            this.gbBasicDetails.Controls.Add(this.rbFemale);
            this.gbBasicDetails.Controls.Add(this.rbMale);
            this.gbBasicDetails.Controls.Add(this.txtLastName);
            this.gbBasicDetails.Controls.Add(this.txtFirstName);
            this.gbBasicDetails.Controls.Add(this.lblGender);
            this.gbBasicDetails.Controls.Add(this.lblDOB);
            this.gbBasicDetails.Controls.Add(this.lblLastName);
            this.gbBasicDetails.Controls.Add(this.lblFirstName);
            this.gbBasicDetails.Location = new System.Drawing.Point(18, 74);
            this.gbBasicDetails.Name = "gbBasicDetails";
            this.gbBasicDetails.Size = new System.Drawing.Size(515, 154);
            this.gbBasicDetails.TabIndex = 1;
            this.gbBasicDetails.TabStop = false;
            this.gbBasicDetails.Text = "Basic Details";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(139, 89);
            this.dtpDOB.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(158, 26);
            this.dtpDOB.TabIndex = 8;
            this.dtpDOB.Value = new System.DateTime(2021, 11, 27, 0, 0, 0, 0);
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(232, 125);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(70, 23);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(139, 125);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 23);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(139, 58);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(350, 26);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(139, 26);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(350, 26);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(22, 127);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 19);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(20, 94);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(87, 19);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(74, 19);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 19);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.Location = new System.Drawing.Point(40, 37);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(54, 19);
            this.lblRegNo.TabIndex = 0;
            this.lblRegNo.Text = "Reg No";
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(157, 34);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(200, 27);
            this.cmbRegNo.TabIndex = 8;
            this.cmbRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbRegNo_SelectedIndexChanged);
            // 
            // linklblLogout
            // 
            this.linklblLogout.AutoSize = true;
            this.linklblLogout.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLogout.ForeColor = System.Drawing.Color.Black;
            this.linklblLogout.Location = new System.Drawing.Point(10, 7);
            this.linklblLogout.Name = "linklblLogout";
            this.linklblLogout.Size = new System.Drawing.Size(64, 21);
            this.linklblLogout.TabIndex = 3;
            this.linklblLogout.TabStop = true;
            this.linklblLogout.Text = "Logout";
            this.linklblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogout_LinkClicked);
            // 
            // linklblExit
            // 
            this.linklblExit.AutoSize = true;
            this.linklblExit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblExit.Location = new System.Drawing.Point(531, 637);
            this.linklblExit.Name = "linklblExit";
            this.linklblExit.Size = new System.Drawing.Size(39, 21);
            this.linklblExit.TabIndex = 4;
            this.linklblExit.TabStop = true;
            this.linklblExit.Text = "Exit";
            this.linklblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblExit_LinkClicked);
            // 
            // errorProviderHphone
            // 
            this.errorProviderHphone.ContainerControl = this;
            // 
            // errorProviderParentName
            // 
            this.errorProviderParentName.ContainerControl = this;
            // 
            // errorProviderNIC
            // 
            this.errorProviderNIC.ContainerControl = this;
            // 
            // errorProviderContactNo
            // 
            this.errorProviderContactNo.ContainerControl = this;
            // 
            // studentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(605, 659);
            this.Controls.Add(this.linklblExit);
            this.Controls.Add(this.linklblLogout);
            this.Controls.Add(this.gbStudentRegistration);
            this.Controls.Add(this.lblSkillsInternational);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "studentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration - Skills International ";
            this.Load += new System.EventHandler(this.studentRegistration_Load);
            this.gbStudentRegistration.ResumeLayout(false);
            this.gbStudentRegistration.PerformLayout();
            this.gbParentDetails.ResumeLayout(false);
            this.gbParentDetails.PerformLayout();
            this.gbContactDetails.ResumeLayout(false);
            this.gbContactDetails.PerformLayout();
            this.gbBasicDetails.ResumeLayout(false);
            this.gbBasicDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSkillsInternational;
        private System.Windows.Forms.GroupBox gbStudentRegistration;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox gbParentDetails;
        private System.Windows.Forms.GroupBox gbContactDetails;
        private System.Windows.Forms.GroupBox gbBasicDetails;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.LinkLabel linklblLogout;
        private System.Windows.Forms.LinkLabel linklblExit;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.ErrorProvider errorProviderHphone;
        private System.Windows.Forms.ErrorProvider errorProviderParentName;
        private System.Windows.Forms.ErrorProvider errorProviderNIC;
        private System.Windows.Forms.ErrorProvider errorProviderContactNo;
    }
}