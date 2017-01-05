using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 电脑锁屏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                errorProvider1.SetError(textBox1, "请输入密码！");
                return;
            }
            errorProvider1.Clear();
            if (textBox1.Text.Length < 6)
            {
                errorProvider1.SetError(textBox1, "请输入大于六位的密码");
                return;
            }
            errorProvider1.Clear();

            if (textBox2.Text=="")
            {
                errorProvider1.SetError(textBox2, "请确认密码！");
                return;
            }
            errorProvider1.Clear();

           

            if (textBox1.Text!=textBox2.Text)
            {
                MessageBox.Show("两次输入密码不同", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Class1.sp = textBox1.Text;
            Form2 str = new Form2();
            str.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("退出此软件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.No)
	        {
                  return;
	        }
            this.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "为了避免给你带来损失，密码区分大小写";
            this.skinEngine1.SkinFile = "CalmnessColor1.ssk";
        }
    }
}
