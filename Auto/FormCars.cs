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
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
            ShowCarss();
        }

        void ShowCarss()
        {
            listView1.Items.Clear();
            foreach (CarSet carSet in Program.AutoDB.CarSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    carSet.ID.ToString(),carSet.Model.ToString(),carSet.Color.ToString(),carSet.Price.ToString(),carSet.GN.ToString(),carSet.Year.ToString()
                });
                item.Tag = carSet;
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCarss();
        }
    }
}
