using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trungtamanhngu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn quay lại không ? ", "Quay lại", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void btclickxem_Click(object sender, EventArgs e)
        {
            if (cobxem.Text == "Lớp Ielts")
            {
                lbketqua.Items.Clear();
                lbketqua.Items.Add(" Thứ 2 - 4 - 6: ");
                lbketqua.Items.Add("    - 7h30 đến 9h30.");
                lbketqua.Items.Add("    - 17h30 đến 19h30.");
                lbketqua.Items.Add(" Ngày khai giảng: ");
                lbketqua.Items.Add("    - 21/09/2020.");
                lbketqua.Items.Add("    - 28/09/2020.");
                lbketqua.Items.Add("  ");
                lbketqua.Items.Add(" Thứ 3 - 5 - 7: ");
                lbketqua.Items.Add("    - 7h30 đến 9h30.");
                lbketqua.Items.Add("    - 17h30 đến 19h30.");
                lbketqua.Items.Add(" Ngày khai giảng: ");
                lbketqua.Items.Add("    - 22/09/2020.");
                lbketqua.Items.Add("    - 29/09/2020.");

            }
            

            if (cobxem.Text == "Lớp Toeic Speaking")
            {                
                lbketqua.Items.Clear();
                lbketqua.Items.Add(" Thứ 2 - 4 - 6: ");
                lbketqua.Items.Add("    - 19h30 đến 21h30.");
                lbketqua.Items.Add(" Ngày khai giảng: ");
                lbketqua.Items.Add("    - 21/09/2020.");
                lbketqua.Items.Add("    - 28/09/2020.");
                lbketqua.Items.Add("  ");
                lbketqua.Items.Add(" Thứ 3 - 5 - 7: ");
                lbketqua.Items.Add("    - 19h30 đến 21h30.");
                lbketqua.Items.Add(" Ngày khai giảng: ");
                lbketqua.Items.Add("    - 22/09/2020.");
                lbketqua.Items.Add("    - 29/09/2020.");
            }
            
            if (cobxem.Text == "Lớp Toeic Listening and Reading")
            {
                lbketqua.Items.Clear();
                lbketqua.Items.Add(" Thứ 2 - 4 - 6: ");
                lbketqua.Items.Add("    - 17h30 đến 19h30.");
                lbketqua.Items.Add(" Ngày khai giảng: ");
                lbketqua.Items.Add("    - 21/09/2020.");
                lbketqua.Items.Add("    - 28/09/2020.");
                lbketqua.Items.Add("  ");
                lbketqua.Items.Add(" Thứ 3 - 5 - 7: ");
                lbketqua.Items.Add("    - 17h30 đến 19h30.");
                lbketqua.Items.Add(" Ngày khai giảng: ");
                lbketqua.Items.Add("    - 22/09/2020.");
                lbketqua.Items.Add("    - 29/09/2020.");
            }
            
            if (cobxem.Text == "Lớp Toeic Writing")
            {
                lbketqua.Items.Clear();
                lbketqua.Items.Add(" Thứ 2 - 4 - 6: ");
                lbketqua.Items.Add("    - 7h30 đến 9h30.");
                lbketqua.Items.Add(" Ngày khai giảng: ");
                lbketqua.Items.Add("    - 21/09/2020.");
                lbketqua.Items.Add("    - 28/09/2020.");
                lbketqua.Items.Add("  ");
                lbketqua.Items.Add(" Thứ 3 - 5 - 7: ");
                lbketqua.Items.Add("    - 7h30 đến 9h30.");
                lbketqua.Items.Add(" Ngày khai giảng: ");
                lbketqua.Items.Add("    - 22/09/2020.");
                lbketqua.Items.Add("    - 29/09/2020.");
            }
            cobxem.ResetText();
            cobxem.SelectedIndex = -1;

        }
    }
}
