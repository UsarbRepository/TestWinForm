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
    public partial class AddEditOrder : Form
    {
        public static int OrderID = 0;
        public static bool IsEdit = false;
        public AddEditOrder()
        {
            InitializeComponent();
        }

        private void ThreadLoading()
        {
            var formLoad = new LoadingForm();
            formLoad.BringToFront();
            formLoad.ShowDialog();
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            ContextDataContext linq = new ContextDataContext(Connection.connection);

            if(!IsEdit)
            {
                AddNewOrder(linq);

                MessageBox.Show("Заказ был успешно создан");
            }
            else
            {
                EditOrder(linq);
                MessageBox.Show("Заказ был успешно изменен");
            }
            this.Close();
        }

        private void EditOrder(ContextDataContext linq)
        {
            var order = linq.Order.FirstOrDefault(el => el.ID == OrderID);

            if (order != null)
            {
                var orderDetails = linq.OrderDetails.FirstOrDefault(el => el.ID == order.OrderDetailID);

                if (orderDetails != null)
                {
                    orderDetails.MenuID = Convert.ToInt16(cbMenu.SelectedValue);
                    orderDetails.Details = tbOrderDetails_Details.Text;
                    linq.SubmitChanges();
                }

                order.PersonalID = Convert.ToInt16(cbPersonal.SelectedValue);
                order.Details = tbOrder_Details.Text;
                linq.SubmitChanges();
            }
        }

        private void AddNewOrder(ContextDataContext linq)
        {
            Thread thread = new Thread(ThreadLoading);
            thread.Start();
            Thread.Sleep(1000);
            try
            {
                var orderDetails = new OrderDetails
                {
                    MenuID = Convert.ToInt16(cbMenu.SelectedValue),
                    Details = tbOrderDetails_Details.Text
                };
                linq.OrderDetails.InsertOnSubmit(orderDetails);
                linq.SubmitChanges();

                var newOrder = new Order
                {
                    PersonalID = Convert.ToInt16(cbPersonal.SelectedValue),
                    OrderDetailID = orderDetails.ID,
                    OrderDate = DateTime.Now,
                    Details = tbOrder_Details.Text
                };
                linq.Order.InsertOnSubmit(newOrder);
                linq.SubmitChanges();
                MessageBox.Show("Новый заказ был создан успешно");
                thread.Abort();
            }
            catch
            {
                thread.Abort();
            }
           
        }

        private void AddEditOrder_Load(object sender, EventArgs e)
        {
            LoadControls();
        }

        private void LoadControls()
        {
            Thread thread = new Thread(ThreadLoading);
            thread.Start();
            Thread.Sleep(1000);
            ContextDataContext linq = new ContextDataContext(Connection.connection);

            var personalList = linq.Personal.ToList();

            cbPersonal.ValueMember = "ID";
            cbPersonal.DisplayMember = "LastName";
            cbPersonal.DataSource = personalList;

            var menuList = linq.Menu.ToList();

            cbMenu.ValueMember = "ID";
            cbMenu.DisplayMember = "Name";
            cbMenu.DataSource = menuList;

            if (IsEdit)
            {
                var order = linq.Order.FirstOrDefault(el => el.ID == OrderID);

                if (order != null)
                {
                    cbPersonal.SelectedValue = order.PersonalID;
                    cbMenu.SelectedValue = order.OrderDetails.MenuID;
                    tbOrderDetails_Details.Text = order.OrderDetails.Details;
                    tbOrder_Details.Text = order.Details;
                }
                else
                {
                    MessageBox.Show("Заказ не был найден");
                }
            }

            thread.Abort();
        }
    }
}
