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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 g = new Form3();
            this.Hide();
            g.ShowDialog();
            this.Show();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lb2.Text = lb2.Text.Substring(1) + lb2.Text.Substring(0, 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 i = new Form4();
            this.Hide();
            i.ShowDialog();
            this.Show();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ Được Nhập Chữ ! ");
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ Được Nhập Số ! ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Focus();

        }

        private void bt6_Click(object sender, EventArgs e)
        {
            nhaptuvan();
        }

        void nhaptuvan()
        {
            if ((txt1.Text == "") && (txt2.Text == "") && (comboBox1.Text == "") || (txt1.Text == "") && (txt2.Text == "") || (txt2.Text == "") && (comboBox1.Text == ""))
            {
                MessageBox.Show(" Nhập đầy đủ thông tin cần tư vấn !");
            }
            else
            {
                if (txt1.Text == "")
                {
                    MessageBox.Show(" Hãy nhập tên học viên !");
                }
                if (txt2.Text == "")
                {
                    MessageBox.Show(" Hãy nhập số điện thoại liên hệ !");//
                }
                if (comboBox1.Text == "")
                {
                    MessageBox.Show(" Hãy chọn khóa luyện thi !");
                }
            } 
           
            if ((txt1.Text != "")&&(txt2.Text != "") && (comboBox1.Text != ""))
            {
                MessageBox.Show(" Đăng ký tư vấn thành công! \n Trung tâm sẽ liên hệ cho bạn trong thời gian sớm nhất. ");
                xoa();
            }

        }

        void xoa()
        {
            txt1.Text = "";
            txt2.Text = "";
            comboBox1.ResetText();
            comboBox1.SelectedIndex = -1;
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thoát", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
     
    }
}
