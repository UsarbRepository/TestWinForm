namespace TestTask
{
    partial class MenuList
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
            this.dtMenuList = new System.Windows.Forms.DataGridView();
            this.menuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMenuForm = new System.Windows.Forms.GroupBox();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.btnSaveMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMenuDetails = new System.Windows.Forms.TextBox();
            this.tbMenuName = new System.Windows.Forms.TextBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtMenuList)).BeginInit();
            this.gbMenuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMenuList
            // 
            this.dtMenuList.AllowUserToAddRows = false;
            this.dtMenuList.AllowUserToDeleteRows = false;
            this.dtMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMenuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuName,
            this.Details});
            this.dtMenuList.Location = new System.Drawing.Point(12, 12);
            this.dtMenuList.Name = "dtMenuList";
            this.dtMenuList.ReadOnly = true;
            this.dtMenuList.RowHeadersVisible = false;
            this.dtMenuList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtMenuList.Size = new System.Drawing.Size(462, 279);
            this.dtMenuList.TabIndex = 0;
            this.dtMenuList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMenuList_CellClick);
            // 
            // menuName
            // 
            this.menuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.menuName.HeaderText = "Название меню";
            this.menuName.Name = "menuName";
            this.menuName.ReadOnly = true;
            this.menuName.Width = 104;
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Details.HeaderText = "Описание";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            // 
            // gbMenuForm
            // 
            this.gbMenuForm.Controls.Add(this.btnClearForm);
            this.gbMenuForm.Controls.Add(this.btnDeleteMenu);
            this.gbMenuForm.Controls.Add(this.btnSaveMenu);
            this.gbMenuForm.Controls.Add(this.label2);
            this.gbMenuForm.Controls.Add(this.label1);
            this.gbMenuForm.Controls.Add(this.tbMenuDetails);
            this.gbMenuForm.Controls.Add(this.tbMenuName);
            this.gbMenuForm.Location = new System.Drawing.Point(480, 12);
            this.gbMenuForm.Name = "gbMenuForm";
            this.gbMenuForm.Size = new System.Drawing.Size(416, 279);
            this.gbMenuForm.TabIndex = 1;
            this.gbMenuForm.TabStop = false;
            this.gbMenuForm.Text = "Меню";
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMenu.Location = new System.Drawing.Point(308, 234);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(102, 39);
            this.btnDeleteMenu.TabIndex = 5;
            this.btnDeleteMenu.Text = "Удалить";
            this.btnDeleteMenu.UseVisualStyleBackColor = true;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // btnSaveMenu
            // 
            this.btnSaveMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMenu.Location = new System.Drawing.Point(191, 234);
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Size = new System.Drawing.Size(102, 39);
            this.btnSaveMenu.TabIndex = 4;
            this.btnSaveMenu.Text = "Сохранить";
            this.btnSaveMenu.UseVisualStyleBackColor = true;
            this.btnSaveMenu.Click += new System.EventHandler(this.btnSaveMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // tbMenuDetails
            // 
            this.tbMenuDetails.Location = new System.Drawing.Point(18, 79);
            this.tbMenuDetails.MaxLength = 256;
            this.tbMenuDetails.Multiline = true;
            this.tbMenuDetails.Name = "tbMenuDetails";
            this.tbMenuDetails.Size = new System.Drawing.Size(392, 149);
            this.tbMenuDetails.TabIndex = 1;
            // 
            // tbMenuName
            // 
            this.tbMenuName.Location = new System.Drawing.Point(18, 36);
            this.tbMenuName.MaxLength = 64;
            this.tbMenuName.Name = "tbMenuName";
            this.tbMenuName.Size = new System.Drawing.Size(392, 20);
            this.tbMenuName.TabIndex = 0;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearForm.Location = new System.Drawing.Point(74, 234);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(102, 39);
            this.btnClearForm.TabIndex = 6;
            this.btnClearForm.Text = "Очистить форму";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // MenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 300);
            this.Controls.Add(this.gbMenuForm);
            this.Controls.Add(this.dtMenuList);
            this.MaximumSize = new System.Drawing.Size(924, 339);
            this.MinimumSize = new System.Drawing.Size(924, 339);
            this.Name = "MenuList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.MenuList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMenuList)).EndInit();
            this.gbMenuForm.ResumeLayout(false);
            this.gbMenuForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMenuList;
        private System.Windows.Forms.GroupBox gbMenuForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMenuDetails;
        private System.Windows.Forms.TextBox tbMenuName;
        private System.Windows.Forms.Button btnSaveMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnClearForm;
    }
}