using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            txtSummary.Clear();

            if (clbSettings.CheckedItems.Count == 0)
            {
                txtSummary.AppendText("Жодного параметра не обрано. Встановлено налаштування за замовчуванням.");
                return;
            }

            foreach (object item in clbSettings.CheckedItems)
            {
                txtSummary.AppendText($"[АКТИВНО] {item}" + Environment.NewLine);
            }

            txtSummary.AppendText("--------------------------------------" + Environment.NewLine);
            txtSummary.AppendText($"Всього змінено параметрів: {clbSettings.CheckedItems.Count}");
        }
    }
}
