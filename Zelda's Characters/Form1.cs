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
                comboBox1.Items.Add(Enter_character.Text); 
                characters_names.Items.Add(Enter_character.Text);
                Character_picture.Load(@"..\..\Images\" + Enter_character.Text + ".jpg");
                Enter_character.Text = ("");
                
               
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
            Character_picture.Load(@"..\..\Images\" + comboBox1.Text + ".jpg");
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
                Character_picture.Load(@"..\..\Images\" + search_character.Text + ".jpg");
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
    }
}
