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
        //Variable para contar cuántas veces se ingresaron palabras
        int contador=0;
        int tictac;
        int seconds;
        int delay;
        int ms;
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add  (textBox1.Text);
            textBox1.Text = ("");
            contador++;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_three_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            button1.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tictac++;
           lbl_four.Text = tictac.ToString();
            if (tictac == 1)
            {
                lbl_four.Text = "Times UP!!!";
                timer1.Stop();  
                button2.Enabled = false;
                timer4.Enabled = true;
                
               
               
            }
        }

        private void lbl_four_Click(object sender, EventArgs e)
        {
               
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
                    delay++;
                    if (delay == 2)
                    lbl_three.Text = (Convert.ToString(contador));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds++;
            lbl_six.Text = (Convert.ToString(seconds));
            if (seconds == 60)
            {
                lbl_six.Text = "";
                timer2.Stop();
                timer3.Stop();
                lbl_five.Text = "";
                lbl_sec.Text = "";
                lbl_ms.Text = "";
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            

            for (int contador = 0; contador < seconds; contador++)
            {   
                
                ms++;
                lbl_five.Text = Convert.ToString(ms);
                if (ms == 1000)
                {
                     
                     timer3.Stop();
                     ms = 0; 
                  }                 
             
               timer3.Start();
               
            } 
            
        }

        private void lbl_five_Click(object sender, EventArgs e)
        {

        }

   
     
    }
}
