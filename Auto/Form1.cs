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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "Пользователь") buttonEditCars.Enabled=false ;
        }

        private void buttonOpenCars_Click(object sender, EventArgs e)
        {
            Form formCars = new FormCars();
            formCars.Show();
        }

        private void buttonEditCars_Click(object sender, EventArgs e)
        {
            Form formEditCars = new FormEditCars();
            formEditCars.Show();
        }
    }
}
