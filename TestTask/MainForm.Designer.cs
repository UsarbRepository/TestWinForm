namespace TestTask
{
    partial class MainForm
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
            this.dtOrdersList = new System.Windows.Forms.DataGridView();
            this.NrOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnChangeMenu = new System.Windows.Forms.Button();
            this.btnChangePersonal = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdersList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtOrdersList
            // 
            this.dtOrdersList.AllowUserToAddRows = false;
            this.dtOrdersList.AllowUserToDeleteRows = false;
            this.dtOrdersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtOrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrOrder,
            this.Personal,
            this.OrderDate,
            this.MenuName,
            this.OrderDetails});
            this.dtOrdersList.Location = new System.Drawing.Point(13, 12);
            this.dtOrdersList.Name = "dtOrdersList";
            this.dtOrdersList.ReadOnly = true;
            this.dtOrdersList.RowHeadersVisible = false;
            this.dtOrdersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtOrdersList.Size = new System.Drawing.Size(612, 281);
            this.dtOrdersList.TabIndex = 0;
            // 
            // NrOrder
            // 
            this.NrOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NrOrder.HeaderText = "Номер";
            this.NrOrder.Name = "NrOrder";
            this.NrOrder.ReadOnly = true;
            this.NrOrder.Width = 66;
            // 
            // Personal
            // 
            this.Personal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Personal.HeaderText = "Официант";
            this.Personal.Name = "Personal";
            this.Personal.ReadOnly = true;
            this.Personal.Width = 83;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OrderDate.HeaderText = "Заказ открыт";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 102;
            // 
            // MenuName
            // 
            this.MenuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MenuName.HeaderText = "Меню";
            this.MenuName.Name = "MenuName";
            this.MenuName.ReadOnly = true;
            this.MenuName.Width = 61;
            // 
            // OrderDetails
            // 
            this.OrderDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDetails.HeaderText = "Детали заказа";
            this.OrderDetails.Name = "OrderDetails";
            this.OrderDetails.ReadOnly = true;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Location = new System.Drawing.Point(13, 299);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(121, 60);
            this.btnAddOrder.TabIndex = 2;
            this.btnAddOrder.Text = "Новый заказ";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnChangeMenu
            // 
            this.btnChangeMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChangeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMenu.Location = new System.Drawing.Point(339, 299);
            this.btnChangeMenu.Name = "btnChangeMenu";
            this.btnChangeMenu.Size = new System.Drawing.Size(121, 60);
            this.btnChangeMenu.TabIndex = 3;
            this.btnChangeMenu.Text = "Редактировать меню";
            this.btnChangeMenu.UseVisualStyleBackColor = true;
            this.btnChangeMenu.Click += new System.EventHandler(this.btnChangeMenu_Click);
            // 
            // btnChangePersonal
            // 
            this.btnChangePersonal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChangePersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePersonal.Location = new System.Drawing.Point(502, 299);
            this.btnChangePersonal.Name = "btnChangePersonal";
            this.btnChangePersonal.Size = new System.Drawing.Size(121, 60);
            this.btnChangePersonal.TabIndex = 4;
            this.btnChangePersonal.Text = "Редактировать персонал";
            this.btnChangePersonal.UseVisualStyleBackColor = true;
            this.btnChangePersonal.Click += new System.EventHandler(this.btnChangePersonal_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Location = new System.Drawing.Point(176, 299);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(121, 60);
            this.btnEditOrder.TabIndex = 5;
            this.btnEditOrder.Text = "Редактировать заказ";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(502, 371);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(123, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 400);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.dtOrdersList);
            this.Controls.Add(this.btnChangePersonal);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnChangeMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtOrdersList;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnChangeMenu;
        private System.Windows.Forms.Button btnChangePersonal;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personal;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDetails;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}