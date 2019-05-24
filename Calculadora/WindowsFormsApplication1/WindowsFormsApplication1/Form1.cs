using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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
        //pulsar btn_seven manda un "7" a la textbox
        private void button1_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = (txbx_screen.Text + "7" );
        }

      
        //Pulsar btn_eight  manda un "8" a la textbox
        private void btn_eight_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = (txbx_screen.Text + "8");
        }
        //Pulsar btn_nine manda un "9" a la textbox 
        private void btn_nine_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = (txbx_screen.Text + "9");
        }
        //pulsar btn_nine manda un "4" a la textbox
        private void btn_four_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = (txbx_screen.Text + "4");
        }
        //pulsar btn_five manda un "5" a la textbox
        private void btn_five_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = (txbx_screen.Text + "5");
        }
        //pulsar btn_six manda un "6" a la textbox
        private void btn_six_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = (txbx_screen.Text + "6");
        }

        //pulsar btn_one manda un "1" a la textbox
        private void btn_one_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = (txbx_screen.Text + "1");
        }
        //pulsar btn_two manda un "2" a la textbox
        private void btn_two_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = (txbx_screen.Text + "2");
        }
        //pulsar btn_three manda un "3" a la textbox
        private void btn_three_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = (txbx_screen.Text + "3");
        } 
        
        //pulsar btn_zero manda un "0" a la textbox
        private void btn_zero_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = (txbx_screen.Text + "0");
        }
        //pulsar btn_dot manda un punto a la textbox
        private void btn_dot_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = (txbx_screen.Text + ".");
        }
        private void btn_division_Click(object sender, EventArgs e)
        {

        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = ("");
        }

        



       

    }
}
