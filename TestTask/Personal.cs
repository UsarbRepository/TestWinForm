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
    public partial class Personals : Form
    {
        public int ID = 0;

        public Personals()
        {
            InitializeComponent();
            dtPersonalList.Visible = false;
            Thread thread = new Thread(ThreadLoading);
            thread.Start();
            Thread.Sleep(1000);
            DrawPersonalInDT();
            thread.Abort();
            dtPersonalList.Visible = true;
        }

        private void ThreadLoading()
        {
            var formLoad = new LoadingForm();
            formLoad.BringToFront();
            formLoad.ShowDialog();
        }

        private void btnSavePersonal_Click(object sender, EventArgs e)
        {
            dtPersonalList.Visible = false;
            Thread thread = new Thread(ThreadLoading);
            thread.Start();
            if (ID != 0)
            {
                EditPersona(tbFirstName.Text, tbLastName.Text, tbPhoneNumber.Text, tbEmail.Text, tbAddress.Text);
                MessageBox.Show("Данные по персоналу успешно обновлены");
            }
            else
            {
                AddNewPersona(tbFirstName.Text, tbLastName.Text, tbPhoneNumber.Text, tbEmail.Text, tbAddress.Text);
                MessageBox.Show("новый персонал успешно добавлен");
            }
            DrawPersonalInDT();
            thread.Abort();
            dtPersonalList.Visible = true;
        }

        private void EditPersona(string _FirstName, string _LastName, string _Phone, string _Email, string _Address)
        {
            ContextDataContext linq = new ContextDataContext(Connection.connection);
            var persona = linq.Personal.FirstOrDefault(el => el.ID == ID);
            if(persona != null)
            {
                persona.FirstName = _FirstName;
                persona.LastName = _LastName;
                persona.Phone = _Phone;
                persona.Email = _Email;
                persona.Address = _Address;
                linq.SubmitChanges();
            }
        }

        public static void AddNewPersona(string _FirstName, string _LastName, string _Phone, string _Email, string _Address)
        {
            ContextDataContext linq = new ContextDataContext(Connection.connection);
            var persona = new Personal
            {
                FirstName = _FirstName,
                LastName = _LastName,
                Phone = _Phone,
                Email = _Email,
                Address = _Address
            };
            linq.Personal.InsertOnSubmit(persona);
            linq.SubmitChanges();
        }

        private void DrawPersonalInDT()
        {          
            try
            {
                dtPersonalList.Rows.Clear();
                ContextDataContext linq = new ContextDataContext(Connection.connection);
                var personal = linq.Personal.ToList();

                foreach (var persona in personal)
                {
                    dtPersonalList.Rows.Add();
                    dtPersonalList[0, dtPersonalList.RowCount - 1].Value = persona.FirstName;
                    dtPersonalList[1, dtPersonalList.RowCount - 1].Value = persona.LastName;
                    dtPersonalList[2, dtPersonalList.RowCount - 1].Value = persona.Phone;
                    dtPersonalList[3, dtPersonalList.RowCount - 1].Value = persona.Email;
                    dtPersonalList[4, dtPersonalList.RowCount - 1].Value = persona.Address;
                    dtPersonalList.Rows[dtPersonalList.RowCount - 1].Tag = persona.ID;
                }
                
            }
            catch
            {
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = tbLastName.Text = tbPhoneNumber.Text = tbEmail.Text = tbAddress.Text = "";
        }

        private void dtPersonalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtPersonalList.RowCount > 0)
            {
                var idPersona = Convert.ToInt16(dtPersonalList.SelectedRows[0].Tag);

                if (idPersona != 0)
                {
                    dtPersonalList.Visible = false;
                    Thread thread = new Thread(ThreadLoading);
                    thread.Start();
                    ContextDataContext linq = new ContextDataContext(Connection.connection);
                    var persona = linq.Personal.FirstOrDefault(el => el.ID == idPersona);
                    if (persona != null)
                    {
                        tbFirstName.Text = persona.FirstName;
                        tbLastName.Text = persona.LastName;
                        tbPhoneNumber.Text = persona.Phone;
                        tbEmail.Text = persona.Email;
                        tbAddress.Text = persona.Address;

                        ID = idPersona;
                    }
                    thread.Abort();
                    dtPersonalList.Visible = true;
                }
            }     
        }

        private void btnDeletePersonal_Click(object sender, EventArgs e)
        {
            if (dtPersonalList.RowCount > 0)
            {
                var IdPersonal = Convert.ToInt16(dtPersonalList.SelectedRows[0].Tag);

                if(IdPersonal != 0)
                {
                    dtPersonalList.Visible = false;
                    Thread thread = new Thread(ThreadLoading);
                    thread.Start();
                    ContextDataContext linq = new ContextDataContext(Connection.connection);
                    var persona = linq.Personal.FirstOrDefault(el => el.ID == IdPersonal);
                    if(persona != null)
                    {
                        linq.Personal.DeleteOnSubmit(persona);
                        linq.SubmitChanges();
                        MessageBox.Show("Сотрудник был удален");
                    }
                    thread.Abort();
                    dtPersonalList.Visible = true;
                }
            }
        }
    }
}
