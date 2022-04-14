using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxValidate( textBox2, textBox3))
            {

               
                double a = int.Parse(textBox2.Text);
                double b = int.Parse(textBox3.Text);


                double c = Math.Sqrt(a * 2 + b * 2);

                if (c > 0)
                {

                    resultLabel.Text = ($"гипотенуза  {c} ");
                }
                else resultLabel.Text = "Нет гипотенузы";
            }

        }

        private bool textBoxValidate(params TextBox[] textBox)
        {

            bool result = true;

            foreach (TextBox t in textBox)
            {
                if (t.Text == "")
                {
                    errorProvider1.SetError(t, "Заполните поле");
                    result = false;
                }
                else errorProvider1.SetError(t, "");
            }

            return result;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

