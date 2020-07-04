using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            ClientSet clientSet = new ClientSet();
            clientSet.Login = textBoxLogin.Text;
            clientSet.Password = textBoxPassword.Text;
            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.Phone = textBoxPhone.Text;
            clientSet.Email = textBoxEmail.Text;
            Program.AutoDB.ClientSet.Add(clientSet);
            Program.AutoDB.SaveChanges();
            MessageBox.Show("Регистрация завершена!", "Теперь вы можете авторизоваться", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
