using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOX
{
    public partial class Form1 : Form
    {
        //public void delete()
        //{
        //    button1.Text = "";
        //    button2.Text = "";
        //    button3.Text = "";
        //    button4.Text = "";
        //    button5.Text = "";
        //    button6.Text = "";
        //    button7.Text = "";
        //    button8.Text = "";
        //    button9.Text = "";
        //}
        public void test_function()
        {
            
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == "S")
                    MessageBox.Show(label1.Text + " kazandı....");
                else
                    MessageBox.Show(label2.Text + " kazandı....");
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button5.Text == "S")
                    MessageBox.Show(label1.Text + " kazandı....");
                else
                    MessageBox.Show(label2.Text + " kazandı....");
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == "S")
                    MessageBox.Show(label1.Text + " kazandı....");
                else
                    MessageBox.Show(label2.Text + " kazandı....");
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == "S")
                    MessageBox.Show(label1.Text + " kazandı....");
                else
                    MessageBox.Show(label2.Text + " kazandı....");
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == "S")
                    MessageBox.Show(label1.Text + " kazandı....");
                else
                    MessageBox.Show(label2.Text + " kazandı....");
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == "S")
                    MessageBox.Show(label1.Text + " kazandı....");
                else
                    MessageBox.Show(label2.Text + " kazandı....");
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == "S")
                    MessageBox.Show(label1.Text + " kazandı....");
                else
                    MessageBox.Show(label2.Text + " kazandı....");
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == "S")
                    MessageBox.Show(label1.Text + " kazandı....");
                else
                    MessageBox.Show(label2.Text + " kazandı....");
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();

        public void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (label1.Visible == true && label2.Visible== false)
                {
                    button1.Text = "S";
                    label1.Visible=false;
                    label2.Visible = true;
                }
                else if (label1.Visible == false && label2.Visible==true)
                {
                    button1.Text = "O";
                    label1.Visible = true;
                    label2.Visible = false;
                }
            }
            test_function();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (label1.Visible == true && label2.Visible == false)
                {
                    button3.Text = "S";
                    label1.Visible = false;
                    label2.Visible = true;
                }
                else if (label1.Visible == false && label2.Visible == true)
                {
                    button3.Text = "O";
                    label1.Visible = true;
                    label2.Visible = false;
                }
            }
            test_function();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (label1.Visible == true && label2.Visible == false)
                {
                    button2.Text = "S";
                    label1.Visible = false;
                    label2.Visible = true;
                }
                else if (label1.Visible == false && label2.Visible == true)
                {
                    button2.Text = "O";
                    label1.Visible = true;
                    label2.Visible = false;
                }
            }
            test_function();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (label1.Visible == true && label2.Visible == false)
                {
                    button6.Text = "S";
                    label1.Visible = false;
                    label2.Visible = true;
                }
                else if (label1.Visible == false && label2.Visible == true)
                {
                    button6.Text = "O";
                    label1.Visible = true;
                    label2.Visible = false;
                }
            }
            test_function();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (label1.Visible == true && label2.Visible == false)
                {
                    button5.Text = "S";
                    label1.Visible = false;
                    label2.Visible = true;
                }
                else if (label1.Visible == false && label2.Visible == true)
                {
                    button5.Text = "O";
                    label1.Visible = true;
                    label2.Visible = false;
                }
            }
            test_function();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (label1.Visible == true && label2.Visible == false)
                {
                    button4.Text = "S";
                    label1.Visible = false;
                    label2.Visible = true;
                }
                else if (label1.Visible == false && label2.Visible == true)
                {
                    button4.Text = "O";
                    label1.Visible = true;
                    label2.Visible = false;
                }
            }
            test_function();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (label1.Visible == true && label2.Visible == false)
                {
                    button7.Text = "S";
                    label1.Visible = false;
                    label2.Visible = true;
                }
                else if (label1.Visible == false && label2.Visible == true)
                {
                    button7.Text = "O";
                    label1.Visible = true;
                    label2.Visible = false;
                }
            }
            test_function();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (label1.Visible == true && label2.Visible == false)
                {
                    button8.Text = "S";
                    label1.Visible = false;
                    label2.Visible = true;
                }
                else if (label1.Visible == false && label2.Visible == true)
                {
                    button8.Text = "O";
                    label1.Visible = true;
                    label2.Visible = false;
                }
            }
            test_function();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (label1.Visible == true && label2.Visible == false)
                {
                    button9.Text = "S";
                    label1.Visible = false;
                    label2.Visible = true;
                }
                else if (label1.Visible == false && label2.Visible == true)
                {
                    button9.Text = "O";
                    label1.Visible = true;
                    label2.Visible = false;
                }
            }
            test_function();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label2.Visible = false;
            label1.Visible = true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            label1.Text = Form2.gonderilecekveri1;
            label2.Text = Form2.gonderilecekveri2;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
