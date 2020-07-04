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
    public partial class FormEditCars : Form
    {
        public FormEditCars()
        {
            InitializeComponent();
            ShowCar();
        }
        void ShowCar()
        {
            listViewCar.Items.Clear();
            foreach (CarSet carSet in Program.AutoDB.CarSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    carSet.ID.ToString(),carSet.Model.ToString(),carSet.Color.ToString(),carSet.Price.ToString(),carSet.GN.ToString(),carSet.Year.ToString()
                });
                item.Tag = carSet;
                listViewCar.Items.Add(item);
            }
            listViewCar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CarSet carSet = new CarSet();
            carSet.Model = textBoxModel.Text;
            carSet.Color = comboBoxColor.SelectedItem.ToString().Split('.')[0];
            carSet.Price = Convert.ToDouble(textBoxPrice.Text);
            carSet.GN = textBoxGN.Text;
            carSet.Year = Convert.ToDouble(textBoxYear.Text);
            Program.AutoDB.CarSet.Add(carSet);
            Program.AutoDB.SaveChanges();
            ShowCar();
        }

        private void listViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (listViewCar.SelectedItems.Count == 1)
                {
                    CarSet carSet = listViewCar.SelectedItems[0].Tag as CarSet;
                    textBoxModel.Text = carSet.Model;
                    comboBoxColor.Text = carSet.Color;
                    textBoxPrice.Text = Convert.ToString(carSet.Price);
                    textBoxGN.Text = carSet.GN;
                    textBoxYear.Text = Convert.ToString(carSet.Year);
                }
                else
                {
                    textBoxModel.Text = "";
                    comboBoxColor.Text = null;
                    textBoxPrice.Text = "";
                    textBoxGN.Text = "";
                    textBoxYear.Text = "";
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCar.SelectedItems.Count == 1)
            {
                CarSet carSet = listViewCar.SelectedItems[0].Tag as CarSet;
                carSet.Model = textBoxModel.Text;
                carSet.Color = comboBoxColor.SelectedItem.ToString().Split('.')[0];
                carSet.Price = Convert.ToDouble(textBoxPrice.Text);
                carSet.GN = textBoxGN.Text;
                carSet.Year = Convert.ToDouble(textBoxYear.Text);
                Program.AutoDB.SaveChanges();
                ShowCar();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCar.SelectedItems.Count == 1)
                {
                    CarSet carSet = listViewCar.SelectedItems[0].Tag as CarSet;
                    Program.AutoDB.CarSet.Remove(carSet);
                    Program.AutoDB.SaveChanges();
                    ShowCar();
                }
                textBoxModel.Text = "";
                comboBoxColor.Text = null;
                textBoxPrice.Text = "";
                textBoxGN.Text = "";
                textBoxYear.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
