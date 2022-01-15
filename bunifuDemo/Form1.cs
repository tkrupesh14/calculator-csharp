using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2;
using ComponentFactory.Krypton.Toolkit;

namespace bunifuDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            guna2CircleProgressBar1.Increment(1);
            if(guna2CircleProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                main main = new bunifuDemo.main();

                main.Show();
                this.Hide();
            }
            
        }
    }
}
