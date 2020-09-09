using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            ContextDataContext linq = new ContextDataContext();

            if(!IsEdit)
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

                MessageBox.Show("Заказ был успешно создан");
            }
            else
            {
                var order = linq.Order.FirstOrDefault(el => el.ID == OrderID);

                if(order!= null)
                {
                    var orderDetails = linq.OrderDetails.FirstOrDefault(el => el.ID == order.OrderDetailID);

                    if(orderDetails != null)
                    {
                        orderDetails.MenuID = Convert.ToInt16(cbMenu.SelectedValue);
                        orderDetails.Details = tbOrderDetails_Details.Text;
                        linq.SubmitChanges();
                    }

                    order.PersonalID = Convert.ToInt16(cbPersonal.SelectedValue);
                    order.Details = tbOrder_Details.Text;
                    linq.SubmitChanges();
                }
                MessageBox.Show("Заказ был успешно изменен");
            }
            this.Close();
        }

        private void AddEditOrder_Load(object sender, EventArgs e)
        {
            ContextDataContext linq = new ContextDataContext();

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

                if(order != null)
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
        }
    }
}
