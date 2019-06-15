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
            
            menu_inicio();

        }


        private void button1_Click(object sender, EventArgs e)
        {           
  
        }
        //la función dibuja la mesa de juego y establece el fondo de la form
        void pintar_mesa()
        {
            Form1.ActiveForm.BackColor = System.Drawing.Color.LightBlue;
            //pintar "marco de madera"
            Graphics madera = this.CreateGraphics();
            Pen marron = new Pen(Color.SaddleBrown, 50);
            madera.DrawEllipse(marron, 220, 120, 600, 375);
            //pintar "tela" verde
            Graphics tela = this.CreateGraphics();
            Pen verde = new Pen(Color.Green, 180);
            tela.DrawEllipse(verde, 320, 220, 400, 175);
        }


        //Función que aparece un menú con las opciones de cuántos jugadores habrán en la partida
        void menu_inicio()
        {
            //fondo del menu
            this.BackColor = System.Drawing.Color.Silver;
            
            //Titulo
            Label lbl_title = new Label();
            lbl_title.Height = 50;
            lbl_title.Width = 525;
            lbl_title.Text = ("¡Bienvenido al Juego del Black Jack!");
            lbl_title.Font = new Font ("Calibri", 25);
            lbl_title.Location = new Point(290, 30);
            Controls.Add(lbl_title);

            //Subtitulo
            Label lbl_subtitle = new Label();
            lbl_subtitle.Height = 50;
            lbl_subtitle.Width = 525;
            lbl_subtitle.Text = ("¿Cuántos jugadores habrán en la partida?");
            lbl_subtitle.Font = new Font("Calibri", 19);
            lbl_subtitle.Location = new Point(310, 100);
            Controls.Add(lbl_subtitle);

            //logo izquierdo
            PictureBox Picbx_left = new PictureBox();
            Picbx_left.Height = 150;
            Picbx_left.Width = 100;
            Picbx_left.Location = new Point(100,40);
            Picbx_left.Load(@"..\..\Menu\logo1.jpg");
            Picbx_left.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Picbx_left);

            //logo derecho
            PictureBox Picbx_right = new PictureBox();
            Picbx_right.Height = 150;
            Picbx_right.Width = 100;
            Picbx_right.Location = new Point(840, 40);
            Picbx_right.Load(@"..\..\Menu\logo2.jpg");
            Picbx_right.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Picbx_right);

            
            //boton un jugador
            Button btn_one_player = new Button();
            btn_one_player.Height = 100;
            btn_one_player.Width = 150;
            btn_one_player.Text = ("Un jugador");
            btn_one_player.Font = new Font("Arial", 16);
            btn_one_player.Location = new Point(320, 200);
            btn_one_player.BackColor = Color.Red;
            Controls.Add(btn_one_player);

            //boton dos jugadores
            Button btn_two_player = new Button();
            btn_two_player.Height = 100;
            btn_two_player.Width = 150;
            btn_two_player.Text = ("Dos jugadores");
            btn_two_player.Font = new Font("Arial", 16);
            btn_two_player.Location = new Point(580, 200);
            btn_two_player.BackColor = Color.WhiteSmoke;
            Controls.Add(btn_two_player);

            //boton tres jugadores
            Button btn_three_player = new Button();
            btn_three_player.Height = 100;
            btn_three_player.Width = 150;
            btn_three_player.Text = ("Tres jugadores");
            btn_three_player.Font = new Font("Arial", 16);
            btn_three_player.Location = new Point(320, 380);
            btn_three_player.BackColor = Color.WhiteSmoke;
            Controls.Add(btn_three_player);

            //boton cuatro jugadores
            Button btn_four_player = new Button();
            btn_four_player.Height = 100;
            btn_four_player.Width = 150;
            btn_four_player.Text = ("Cuatro jugadores");
            btn_four_player.Font = new Font("Arial", 16);
            btn_four_player.Location = new Point(580, 380);
            btn_four_player.BackColor = Color.Red;
            Controls.Add(btn_four_player);


        }




    }
}
