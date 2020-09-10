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
    public partial class MenuList : Form
    {
        public int ID = 0;
        public MenuList()
        {
            InitializeComponent();
            dtMenuList.Visible = false;
            Thread thread = new Thread(ThreadLoading);
            thread.Start();
            Thread.Sleep(1000);
            DrawListmenuInDT();
            thread.Abort();
            dtMenuList.Visible = true;
        }
        private void ThreadLoading()
        {
            var formLoad = new LoadingForm();
            formLoad.BringToFront();
            formLoad.ShowDialog();
        }

        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            dtMenuList.Visible = false;
            Thread thread = new Thread(ThreadLoading);
            thread.Start();
            Thread.Sleep(1000);
            ContextDataContext linq = new ContextDataContext(Connection.connection);
            if(ID == 0)
            {
                var menu = new Menu
                {
                    Name = tbMenuName.Text,
                    Details = tbMenuDetails.Text
                };
                linq.Menu.InsertOnSubmit(menu);
                linq.SubmitChanges();
                MessageBox.Show("Меню успешно добавлено");
            }
            else
            {
                var menu = linq.Menu.FirstOrDefault(el => el.ID == ID);

                if (menu != null)
                {
                    menu.Name = tbMenuName.Text;
                    menu.Details = tbMenuDetails.Text;
                    linq.SubmitChanges();
                    MessageBox.Show("Меню успешно изменено");
                }
            }
            thread.Abort();
            dtMenuList.Visible = true;
            ResetControls();
            DrawListmenuInDT();
        }

        private void DrawListmenuInDT()
        {
            dtMenuList.Rows.Clear();
            ContextDataContext linq = new ContextDataContext(Connection.connection);
            var listMenu = linq.Menu.ToList();

            foreach (var menu in listMenu)
            {
                dtMenuList.Rows.Add();
                dtMenuList[0, dtMenuList.RowCount - 1].Value = menu.Name;
                dtMenuList[1, dtMenuList.RowCount - 1].Value = menu.Details;
                dtMenuList.Rows[dtMenuList.RowCount - 1].Tag = menu.ID;
            }
        }

        private void dtMenuList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtMenuList.RowCount > 0)
            {
                var idMenu = Convert.ToInt16(dtMenuList.SelectedRows[0].Tag);

                if (idMenu != 0)
                {
                    dtMenuList.Visible = false;
                    Thread thread = new Thread(ThreadLoading);
                    thread.Start();
                    Thread.Sleep(1000);
                    ContextDataContext linq = new ContextDataContext(Connection.connection);
                    var menu = linq.Menu.FirstOrDefault(el => el.ID == idMenu);

                    if (menu != null)
                    {
                        tbMenuName.Text = menu.Name;
                        tbMenuDetails.Text = menu.Details;
                        ID = menu.ID;
                    }
                    thread.Abort();
                    dtMenuList.Visible = true;
                }
            }
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            if(dtMenuList.RowCount > 0)
            {
                var idMenu = Convert.ToInt16(dtMenuList.SelectedRows[0].Tag);

                if (idMenu != 0)
                {
                    dtMenuList.Visible = false;
                    Thread thread = new Thread(ThreadLoading);
                    thread.Start();
                    Thread.Sleep(1000);
                    ContextDataContext linq = new ContextDataContext(Connection.connection);
                    var menu = linq.Menu.FirstOrDefault(el => el.ID == idMenu);

                    if (menu != null)
                    {
                        linq.Menu.DeleteOnSubmit(menu);
                        linq.SubmitChanges();
                        DrawListmenuInDT();
                        ResetControls();
                        MessageBox.Show("Меню успешно удалено");
                    }
                    thread.Abort();
                    dtMenuList.Visible = true;
                }
            }
            
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void ResetControls()
        {
            tbMenuName.Text = tbMenuDetails.Text = "";
            ID = 0;
        }
    }
}
