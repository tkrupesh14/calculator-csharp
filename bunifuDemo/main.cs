using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace bunifuDemo
{
    public partial class main : KryptonForm

    {
    
        public main()
        {
            InitializeComponent();
            
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(Value1.Text);
            double val2 = Convert.ToDouble(Value2.Text);

            double sum = val1 + val2;

            Output.Text = sum.ToString();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/krupesh.vithlani");
        }

        private void Value1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Minus_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(Value1.Text);
            double val2 = Convert.ToDouble(Value2.Text);

            double sum = val1 - val2;

            Output.Text = sum.ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(Value1.Text);
            double val2 = Convert.ToDouble(Value2.Text);

            double sum = val1 * val2;

            Output.Text = sum.ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(Value1.Text);
            double val2 = Convert.ToDouble(Value2.Text);

            double sum = val1 / val2;

            Output.Text = sum.ToString();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/krupeshvithlani14");
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tkrupesh14");
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linkedin.com/in/krupeshvithlani");
        }
    }
}
