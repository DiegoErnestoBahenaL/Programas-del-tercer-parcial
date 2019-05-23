using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApplication1
{    
    public partial class Form1 : Form
    {



        int ticks = 0;
        int ticks1 = 0;
        int ticks2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                    timer1.Enabled = true; 
            }
        }

        private void serch_character_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void characters_names_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = ("");
            timer3.Enabled = true;
            Character_picture.Visible = false;
            richTextBox1.Visible = false;
          
            Character_picture.Load(@"..\..\Images\" + comboBox1.Text + ".jpg");
            StreamReader read_info = new StreamReader(@"..\..\Info\" + comboBox1.Text + ".txt");

            string line;

            line = read_info.ReadLine();
            while (line != null)
            {
                richTextBox1.AppendText(line);
                line = read_info.ReadLine();
            }
            read_info.Close();  

        }

        private void Character_picture_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void serch_character_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar (Keys.Enter))
            {
                timer2.Enabled = true;
                
            }


        }

        private void characters_names_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                DialogResult Answer = MessageBox.Show("El personaje " + characters_names.Text + " será eliminado, ¿Está seguro?", "Advertencia", MessageBoxButtons.YesNo);

                if (Answer == DialogResult.Yes)
                {
                    characters_names.Items.RemoveAt(characters_names.SelectedIndex);
                }

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text = ("");
            Character_picture.Visible = false;
            richTextBox1.Visible = false;
            ticks++;
            progressBar1.Visible = true;
            progressBar1.Value = ticks;
            if (ticks == 100)
            {
                timer1.Stop();
                progressBar1.Visible = false;
                ticks = 0;
                color_random();
                Character_picture.Visible = true;
                richTextBox1.Visible = true;
                comboBox1.Items.Add(Enter_character.Text);

                characters_names.Items.Add(Enter_character.Text);

                Character_picture.Load(@"..\..\Images\" + Enter_character.Text + ".jpg");

                StreamReader read_info = new StreamReader(@"..\..\Info\" + Enter_character.Text + ".txt");

                string line;

                line = read_info.ReadLine();
                while (line != null)
                {
                    richTextBox1.AppendText(line);
                    line = read_info.ReadLine();
                }
                read_info.Close();
                Enter_character.Text = ("");

            }

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text = ("");
            Character_picture.Visible = false;
            richTextBox1.Visible = false;
            progressBar1.Visible = true;
            ticks1++;
            progressBar1.Value = ticks1;
            if (ticks1 == 100)
            {
                timer2.Stop();
                progressBar1.Visible = false;
                ticks1 = 0;
                Character_picture.Visible = true;
                richTextBox1.Visible = true;
                color_random();
                Character_picture.Load(@"..\..\Images\" + search_character.Text + ".jpg");

                StreamReader read_info = new StreamReader(@"..\..\Info\" + search_character.Text + ".txt");

                string line;

                line = read_info.ReadLine();
                while (line != null)
                {
                    richTextBox1.AppendText(line);
                    line = read_info.ReadLine();
                }
                read_info.Close();
                search_character.Text = ("");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ticks2++;
            progressBar1.Visible = true;
            progressBar1.Value = ticks2;
            if (ticks2 == 100)
            {
                timer3.Stop();
                progressBar1.Visible = false;
                ticks2 = 0;
                Character_picture.Visible = true;
                richTextBox1.Visible = true;  
                color_random();
            }
         
        }
        //Función para obtener un color aleatorio
        void color_random()
        {
            //la función utiliza el metodo FromArgb, combinando tres variables aleatorias del 1 al 255 (rango de color) para
            //obtener un color segun la combinación RGB. rango1 tomese como "red", rango 2 como "blue" y rango3 como "green"  
            //El color resultante se refleja en el back color de la form;
            Random colors = new Random(DateTime.Now.Millisecond);
            int rango1 = colors.Next(1, 255);
            int rango2 = colors.Next(1, 255);
            int rango3 = colors.Next(1, 255);
            Form1.ActiveForm.BackColor = Color.FromArgb(rango1, rango2, rango3);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
