using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChangeMenu_Click(object sender, EventArgs e)
        {
            MenuList menu = new MenuList();
            menu.ShowDialog();
        }

        private void btnChangePersonal_Click(object sender, EventArgs e)
        {
            Personals personal = new Personals();
            personal.ShowDialog();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddEditOrder addEditOrder = new AddEditOrder();
            AddEditOrder.OrderID = 0;
            AddEditOrder.IsEdit = false;
            addEditOrder.ShowDialog();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            AddEditOrder addEditOrder = new AddEditOrder();
            AddEditOrder.OrderID = Convert.ToInt16(dtOrdersList.SelectedRows[0].Tag);
            AddEditOrder.IsEdit = true;
            addEditOrder.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Blocks;
            Thread loading = new Thread(new ThreadStart(GetListOrder));
            loading.Start();
        }
        private void GetListOrder()
        {
            ContextDataContext linq = new ContextDataContext();
            List<Order> orderList = linq.Order.ToList();
            DrawListOrdersInDT(orderList);
        }

        internal delegate void DrawListOrderDelegate(List<Order> orders);
        private void DrawListOrdersInDT(List<Order> orderList)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new DrawListOrderDelegate(DrawListOrdersInDT), orderList);
            }
            else
            {
                dtOrdersList.Rows.Clear();
                if (orderList.Count != 0)
                {
                    foreach (var order in orderList)
                    {
                        dtOrdersList.Rows.Add();
                        dtOrdersList[0, dtOrdersList.RowCount - 1].Value = order.ID;
                        dtOrdersList[1, dtOrdersList.RowCount - 1].Value = order.Personal.FirstName + " " + order.Personal.LastName;
                        dtOrdersList[2, dtOrdersList.RowCount - 1].Value = order.OrderDate;
                        dtOrdersList[3, dtOrdersList.RowCount - 1].Value = order.OrderDetails.Menu.Name;
                        dtOrdersList[4, dtOrdersList.RowCount - 1].Value = order.Details;
                        dtOrdersList.Rows[dtOrdersList.RowCount - 1].Tag = order.ID;
                    }
                }
                progressBar1.Visible = false;
            }
        }

        

        private void MainForm_Activated(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            Thread loading = new Thread(new ThreadStart(GetListOrder));
            loading.Start();
        }
    }
}
