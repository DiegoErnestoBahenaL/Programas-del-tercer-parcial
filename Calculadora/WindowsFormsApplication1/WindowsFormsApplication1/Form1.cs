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

        //string signo recibe qué operación se realizará
        string signo = "";
        //num1 y num2 reciben los numeros ingresados por el usuario
        float num1 = 0;
        float num2 = 0;
                 
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
       //función que registra el primer numero ingresado por el usuario
        void registrar_num1()
        {
            num1 = float.Parse(txbx_screen.Text);
            txbx_screen.Text = ("");
        }
        //pulsar btn_sum manda el signo de "+" a la variable signo
        private void btn_sum_Click(object sender, EventArgs e)
        {
           signo = "+";
           registrar_num1();
          
        }
        //pulsar btn_rest manda "-" a la variable signo
        private void btn_rest_Click(object sender, EventArgs e)
        {
            signo = "-";
            registrar_num1();

        }
        //pulsar btn_division manda "/" a la variable signo
        private void btn_division_Click(object sender, EventArgs e)
        {
            signo = "/";
            registrar_num1();
        }
        //pulsar btn_multp manda "*" a la variable signo
        private void btn_multp_Click(object sender, EventArgs e)
        {
            signo = "*";
            registrar_num1();
        }
    //En el btn_result depende el signo mandado la operación a realizar, pero en general realiza las operaciones
        private void btn_result_Click(object sender, EventArgs e)
        {
                  //suma  
                  if (signo == "+")
                  {
                      num2 = float.Parse (txbx_screen.Text);
                      num1 += num2;
                      txbx_screen.Text = Convert.ToString(num1);
                  }
                  //resta
                  if (signo == "-")
                  {
                      num2 = float.Parse(txbx_screen.Text);
                      num1 -= num2;
                      txbx_screen.Text = Convert.ToString(num1);
                  }
                  //division
                  if (signo == "/")
                  {
                      num2 = float.Parse(txbx_screen.Text);
                      num1 /= num2;
                      txbx_screen.Text = Convert.ToString(num1);
                  }
                  //multiplicación
                  if (signo == "*")
                  {
                      num2 = float.Parse(txbx_screen.Text);
                      num1 *= num2;
                      txbx_screen.Text = Convert.ToString(num1);
                  }
        }
       //pulsar btn_CE limpia la textbox y borra los datos de num1 y num2
        private void btn_CE_Click(object sender, EventArgs e)
        {
            txbx_screen.Text = ("");
            num1 = 0;
            num2 = 0;
           
        }

       

    }
}
