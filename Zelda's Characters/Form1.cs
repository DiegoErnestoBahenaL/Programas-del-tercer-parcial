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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                comboBox1.Items.Add(textBox1.Text); 
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = ("");
               
            }
        }
    }
}
