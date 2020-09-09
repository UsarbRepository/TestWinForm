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
        }

        private void btnSavePersonal_Click(object sender, EventArgs e)
        {
            if(ID != 0)
            {
                EditPersona(tbFirstName.Text, tbLastName.Text, tbPhoneNumber.Text, tbEmail.Text, tbAddress.Text);
            }
            else
            {
                AddNewPersona(tbFirstName.Text, tbLastName.Text, tbPhoneNumber.Text, tbEmail.Text, tbAddress.Text);
            }
            DrawPersonalInDT();
        }

        private void EditPersona(string _FirstName, string _LastName, string _Phone, string _Email, string _Address)
        {
            ContextDataContext linq = new ContextDataContext();
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

        private void Personals_Load(object sender, EventArgs e)
        {
            DrawPersonalInDT();
        }

        public static void AddNewPersona(string _FirstName, string _LastName, string _Phone, string _Email, string _Address)
        {
            ContextDataContext linq = new ContextDataContext();
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
            dtPersonalList.Rows.Clear();
            ContextDataContext linq = new ContextDataContext();
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

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = tbLastName.Text = tbPhoneNumber.Text = tbEmail.Text = tbAddress.Text = "";
        }

        private void dtPersonalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var idPersona = Convert.ToInt16(dtPersonalList.SelectedRows[0].Tag);

            if(idPersona != 0)
            {
                ContextDataContext linq = new ContextDataContext();
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
            }
        }
    }
}
