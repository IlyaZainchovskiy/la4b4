using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbMelodies.SelectedItem != null)
            {
                string selectedItem = cbMelodies.SelectedItem.ToString();

                if (!lbSelectedMelodies.Items.Contains(selectedItem))
                {
                    lbSelectedMelodies.Items.Add(selectedItem);
                }
                else
                {
                    MessageBox.Show("Цей твір вже є у вашому списку!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
