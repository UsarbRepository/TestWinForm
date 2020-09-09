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
    public partial class MenuList : Form
    {
        public int ID = 0;
        public MenuList()
        {
            InitializeComponent();
        }

        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            ContextDataContext linq = new ContextDataContext();
            if(ID == 0)
            {
                var menu = new Menu
                {
                    Name = tbMenuName.Text,
                    Details = tbMenuDetails.Text
                };
                linq.Menu.InsertOnSubmit(menu);
                linq.SubmitChanges();
            }
            else
            {
                var menu = linq.Menu.FirstOrDefault(el => el.ID == ID);

                if (menu != null)
                {
                    menu.Name = tbMenuName.Text;
                    menu.Details = tbMenuDetails.Text;
                    linq.SubmitChanges();
                   
                }
            }
            ResetControls();
            DrawListmenuInDT();
        }

        private void MenuList_Load(object sender, EventArgs e)
        {
            DrawListmenuInDT();
        }

        private void DrawListmenuInDT()
        {
            dtMenuList.Rows.Clear();
            ContextDataContext linq = new ContextDataContext();
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
            var idMenu = Convert.ToInt16(dtMenuList.SelectedRows[0].Tag);

            if(idMenu != 0)
            {
                ContextDataContext linq = new ContextDataContext();
                var menu = linq.Menu.FirstOrDefault(el => el.ID == idMenu);

                if(menu != null)
                {
                    tbMenuName.Text = menu.Name;
                    tbMenuDetails.Text = menu.Details;
                    ID = menu.ID;
                }
            }
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            var idMenu = Convert.ToInt16(dtMenuList.SelectedRows[0].Tag);

            if (idMenu != 0)
            {
                ContextDataContext linq = new ContextDataContext();
                var menu = linq.Menu.FirstOrDefault(el => el.ID == idMenu);

                if (menu != null)
                {
                    linq.Menu.DeleteOnSubmit(menu);
                    linq.SubmitChanges();
                    DrawListmenuInDT();
                    ResetControls();
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
