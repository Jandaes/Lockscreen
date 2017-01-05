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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       int num = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text=="")
            {
                errorProvider1.SetError(textBox1, "请输入解锁密码");
                return;
            }
            errorProvider1.Clear();

            if (this.textBox1.Text != Class1.sp)
            {
                label2.Visible = true;
            }
            else 
            {
                this.Close();
            }
            timer2.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            num++;
            if (this.textBox1.Text.Trim().Length == 0)
            {
                this.label2.Visible = false;
                return;
            }
            if (num >= 5)
            {
                this.label2.Visible = true;
                timer2.Stop();
                num = 0;
                return;
            }
            if (num % 2 == 0)
            {
                this.label2.Visible = false;
            }
            else
            {
                this.label2.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text =DateTime.Now.ToString();
            if (this.textBox1.Text.Trim().Length == 0)
            {
                this.label2.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //屏蔽crlt+F4
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
            {
                e.Handled = true;
            }
            e.Handled = false;

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text!=Class1.sp)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }



       
       

        
    }
}
