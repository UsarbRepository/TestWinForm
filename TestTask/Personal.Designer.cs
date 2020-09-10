namespace TestTask
{
    partial class Personals
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
            this.dtPersonalList = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnDeletePersonal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btnSavePersonal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtPersonalList
            // 
            this.dtPersonalList.AllowUserToAddRows = false;
            this.dtPersonalList.AllowUserToDeleteRows = false;
            this.dtPersonalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPersonalList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Phone,
            this.Email,
            this.Address});
            this.dtPersonalList.Location = new System.Drawing.Point(12, 12);
            this.dtPersonalList.MultiSelect = false;
            this.dtPersonalList.Name = "dtPersonalList";
            this.dtPersonalList.ReadOnly = true;
            this.dtPersonalList.RowHeadersVisible = false;
            this.dtPersonalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtPersonalList.Size = new System.Drawing.Size(702, 248);
            this.dtPersonalList.TabIndex = 1;
            this.dtPersonalList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPersonalList_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 54;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 81;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Phone.HeaderText = "Номер телефона";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 108;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.HeaderText = "Емайл";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 65;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearForm);
            this.groupBox1.Controls.Add(this.btnDeletePersonal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPhoneNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.btnSavePersonal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 186);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудник";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearForm.Location = new System.Drawing.Point(342, 133);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(102, 39);
            this.btnClearForm.TabIndex = 12;
            this.btnClearForm.Text = "Очистить форму";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnDeletePersonal
            // 
            this.btnDeletePersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePersonal.Location = new System.Drawing.Point(580, 133);
            this.btnDeletePersonal.Name = "btnDeletePersonal";
            this.btnDeletePersonal.Size = new System.Drawing.Size(102, 39);
            this.btnDeletePersonal.TabIndex = 11;
            this.btnDeletePersonal.Text = "Удалить";
            this.btnDeletePersonal.UseVisualStyleBackColor = true;
            this.btnDeletePersonal.Click += new System.EventHandler(this.btnDeletePersonal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Емайл";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(8, 88);
            this.tbEmail.MaxLength = 64;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер телефона";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(482, 37);
            this.tbPhoneNumber.MaxLength = 16;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.tbPhoneNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фамилия";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(244, 37);
            this.tbLastName.MaxLength = 256;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 20);
            this.tbLastName.TabIndex = 5;
            // 
            // btnSavePersonal
            // 
            this.btnSavePersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePersonal.Location = new System.Drawing.Point(461, 133);
            this.btnSavePersonal.Name = "btnSavePersonal";
            this.btnSavePersonal.Size = new System.Drawing.Size(102, 39);
            this.btnSavePersonal.TabIndex = 4;
            this.btnSavePersonal.Text = "Сохранить";
            this.btnSavePersonal.UseVisualStyleBackColor = true;
            this.btnSavePersonal.Click += new System.EventHandler(this.btnSavePersonal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(244, 88);
            this.tbAddress.MaxLength = 256;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(438, 20);
            this.tbAddress.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(8, 37);
            this.tbFirstName.MaxLength = 256;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // Personals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtPersonalList);
            this.Name = "Personals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtPersonalList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btnSavePersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnDeletePersonal;
    }
}