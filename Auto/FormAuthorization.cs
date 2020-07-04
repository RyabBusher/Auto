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
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }
        public struct User
        {
            public string login;
            public string password;
            public string type;
        }
        public static User users = new User();

        public void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (ClientSet clientSet in Program.AutoDB.ClientSet)
                {
                    if (textBoxLogin.Text == clientSet.Login && textBoxPassword.Text == clientSet.Password && comboBoxType.SelectedItem.ToString() == "Пользователь")
                    {
                        key = true;
                        users.login = clientSet.Login;
                        users.password = clientSet.Password;
                        users.type = "Пользователь";
                    }
                }
                foreach (ManagerSet managerSet in Program.AutoDB.ManagerSet)
                {
                    if (textBoxLogin.Text == managerSet.Login && textBoxPassword.Text == managerSet.Password && comboBoxType.SelectedItem.ToString()=="Модератор")
                    {
                        key = true;
                        users.login = managerSet.Login;
                        users.password = managerSet.Password;
                        users.type = "Модератор";
                    }
                }
                    if (!key)
                    {
                        MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxLogin.Text = "";
                        textBoxPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Данные введены верно", "Добро пожаловать!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 menu = new Form1();
                        menu.Show();
                        this.Hide();
                    }
                }
            }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Form formReg = new FormReg();
            formReg.Show();
        }
    }
    }
