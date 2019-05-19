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
            if ( e.KeyChar == Convert.ToChar(Keys.Enter))
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

        }

        private void Character_picture_Click(object sender, EventArgs e)
        {

        }
    }
}
