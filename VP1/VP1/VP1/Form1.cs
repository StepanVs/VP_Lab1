using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP1
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public string num1;
        string temp1 = "";
        string temp2 = "";
        string temp3 = "";
        string temp4 = "";
        public bool check = false;
        public bool SecondCheck = false;
        public int iter = 0;
        public int[] mas = { 0, 0, 0, 0};
        public int[] mas2 = { 0, 0, 0, 0};
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0") textBox1.Text = B.Text;
            else textBox1.Text = textBox1.Text + B.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            Binary.Text = "";
            Hex.Text = "";
            Decimal.Text = "";
            Octal.Text = "";
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);

            if (D == "+") res = dn1 + dn2;
            if (D == "-") res = dn1 - dn2;
            if (D == "x") res = dn1 * dn2;
            if (D == "/") res = dn1 / dn2;
            D = "=";
            n2 = true;
            textBox1.Text = res.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",") && !textBox1.Text.Contains(".")) textBox1.Text = textBox1.Text + ",";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "") textBox1.Text = "0";
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            int numConvert = int.Parse(textBox1.Text);
            Binary.Text = Convert.ToString(numConvert, 2);
            Decimal.Text = numConvert.ToString();
            Hex.Text = Convert.ToString(numConvert, 16);
            Octal.Text = Convert.ToString(numConvert, 8);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                textBox2.Text = textBox2.Text + "0";
                temp1 += "1";
                //temp2 += "0";
            }
            else
            {
                if (SecondCheck == false)
                {
                    textBox2.Text = textBox2.Text + "0";
                    mas[iter] = 0;
                    iter++;
                }
                else
                {
                    textBox2.Text = textBox2.Text + "0";
                    mas2[iter] = 0;
                    iter++;
                }
                //temp3 += "0";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                textBox2.Text = textBox2.Text + "1";
                temp1 += "0";
                //temp2 += "1";
            }
            else
            {
                if (SecondCheck == false)
                {
                    textBox2.Text = textBox2.Text + "1";
                    mas[iter] = 1;
                    iter++;
                }
                else
                {
                    textBox2.Text = textBox2.Text + "1";
                    mas2[iter] = 1;
                    iter++;
                }
                //temp3 += "1";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "") textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < iter; i++)
            {
                mas[i] = mas[i] + mas2[i];
                if (mas[i] >= 1) temp4 += "1";
                else temp4 += "0";
            }
            textBox2.Text = temp4;
            iter = 0;
            check = false;
            SecondCheck = false;
            temp4 = "";

            //=
            //double T2, T3, T4;
            //T2 = Convert.ToDouble(temp2);
            //T3 = Convert.ToDouble(temp3);
            //T4 = T2 + T3;
            //temp4 = Convert.ToString(T4);
            //temp4.Replace("22", "11");
            ////temp4 = temp2 + temp3;
            //textBox2.Text = temp4;
            //temp1 = "";
            //temp2 = "";
            //temp3 = "";
            //check = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = temp1;
            temp1 = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            iter = 0;
            check = true;
            SecondCheck = true;
            textBox2.Text = "";
        }
    }
}
