using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Programa_Black_Jack
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


        private void button1_Click(object sender, EventArgs e)
        {
            Graphics madera = this.CreateGraphics();
            Pen marron = new Pen(Color.SaddleBrown, 50);
            madera.DrawEllipse(marron, 220, 120, 600, 375);

            Graphics tela = this.CreateGraphics();
            Pen verde = new Pen(Color.Green, 180);
            tela.DrawEllipse(verde, 320, 220, 400, 175);

        }

    }
}
