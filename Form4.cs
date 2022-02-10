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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn quay lại không ?", "Quay lại", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }


        private void txthoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không được nhập kí tự số ");
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txthoten.Text != "") && (txtsdt.Text != "") && (cobcahoc.Text != "") && (coblop.Text != "") && (cobngay.Text != "") && (cobthu.Text != ""))
            {
                MessageBox.Show(" Đăng ký thành công! \n Trung tâm sẽ liên hệ cho bạn trong thời gian sớm nhất. ");
                xoatext();
                cobcahoc.Items.Clear();
                cobngay.Items.Clear();
    
            }
            else
                MessageBox.Show("Điền đầy đủ thông tin đăng ký ! ");
        }

        void xoatext()
        {
            txtsdt.Text = "";
            txthoten.Text = "";
            cobthu.ResetText();
            cobthu.SelectedIndex = -1;
            cobngay.ResetText();
            cobngay.SelectedIndex = -1;
            coblop.ResetText();
            coblop.SelectedIndex = -1;
            cobcahoc.ResetText();
            cobcahoc.SelectedIndex = -1;

        }

        private void coblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coblop.Text == "Lớp Ielts")
            {
                cobcahoc.Items.Clear();
                cobcahoc.Items.ToString();
                cobcahoc.Items.Add("7h30-9h30");
                cobcahoc.Items.Add("17h30-19h30");
            }
            if (coblop.Text == "Lớp Toeic Speaking")
            {
                cobcahoc.Items.Clear();
                cobcahoc.Items.ToString();
                cobcahoc.Items.Add("19h30 - 21h30");
            }
            if (coblop.Text == "Lớp Toeic Listening and Reading")
            {
                cobcahoc.Items.Clear();
                cobcahoc.Items.ToString();
                cobcahoc.Items.Add("17h30 - 19h30");
            }
            if (coblop.Text == "Lớp Toeic Writing")
            {
                cobcahoc.Items.Clear();
                cobcahoc.Items.ToString();
                cobcahoc.Items.Add("7h30 - 9h30");
            }

        }

        private void cobthu_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (cobthu.Text == "2 - 4 - 6")
            {
                cobngay.Items.Clear();
                cobngay.Items.ToString();
                cobngay.Items.Add("21 - 9 - 2020");
                cobngay.Items.Add("28 - 9 - 2020");

            }
            if (cobthu.Text == "3 - 5 - 7")
            {
                cobngay.Items.Clear();
                cobngay.Items.ToString();
                cobngay.Items.Add("22 - 9 - 2020");
                cobngay.Items.Add("29 - 9 - 2020");
            }
        }
    }
}
