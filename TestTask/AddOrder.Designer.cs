namespace TestTask
{
    partial class AddEditOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersonal = new System.Windows.Forms.ComboBox();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOrderDetails_Details = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOrder_Details = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сотрудник";
            // 
            // cbPersonal
            // 
            this.cbPersonal.FormattingEnabled = true;
            this.cbPersonal.Location = new System.Drawing.Point(12, 25);
            this.cbPersonal.Name = "cbPersonal";
            this.cbPersonal.Size = new System.Drawing.Size(211, 21);
            this.cbPersonal.TabIndex = 1;
            // 
            // cbMenu
            // 
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(257, 25);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(211, 21);
            this.cbMenu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Меню";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrder.Location = new System.Drawing.Point(366, 196);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(102, 39);
            this.btnSaveOrder.TabIndex = 5;
            this.btnSaveOrder.Text = "Сохранить";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Примечание к меню";
            // 
            // tbOrderDetails_Details
            // 
            this.tbOrderDetails_Details.Location = new System.Drawing.Point(12, 79);
            this.tbOrderDetails_Details.MaxLength = 256;
            this.tbOrderDetails_Details.Multiline = true;
            this.tbOrderDetails_Details.Name = "tbOrderDetails_Details";
            this.tbOrderDetails_Details.Size = new System.Drawing.Size(211, 95);
            this.tbOrderDetails_Details.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Примечание к заказу";
            // 
            // tbOrder_Details
            // 
            this.tbOrder_Details.Location = new System.Drawing.Point(257, 79);
            this.tbOrder_Details.MaxLength = 256;
            this.tbOrder_Details.Multiline = true;
            this.tbOrder_Details.Name = "tbOrder_Details";
            this.tbOrder_Details.Size = new System.Drawing.Size(211, 95);
            this.tbOrder_Details.TabIndex = 8;
            // 
            // AddEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 247);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOrder_Details);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOrderDetails_Details);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.cbMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPersonal);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(489, 286);
            this.MinimumSize = new System.Drawing.Size(489, 286);
            this.Name = "AddEditOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заказа";
            this.Load += new System.EventHandler(this.AddEditOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPersonal;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOrderDetails_Details;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOrder_Details;
    }
}