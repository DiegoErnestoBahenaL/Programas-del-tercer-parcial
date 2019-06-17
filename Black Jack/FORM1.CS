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
using System.IO;
using System.Media;
 
namespace Programa_Black_Jack
{ 
             
    public partial class Form1 : Form
    { 
        //Controles del menu
        Label lbl_title = new Label();
        Label lbl_subtitle = new Label();
        PictureBox Picbx_left = new PictureBox();
        PictureBox Picbx_right = new PictureBox();
        Button btnoneplayer = new Button();
        Button btntwoplayer = new Button();
        Button btnthreeplayer = new Button();
        Button btnfourplayer = new Button(); 
        SoundPlayer MenuSong;
        SoundPlayer GameSong;


        //controles del juego
        PictureBox Picbxdealer = new PictureBox();
        PictureBox Picbxplayer1 = new PictureBox();
        PictureBox Picbxplayer2 = new PictureBox();
        PictureBox Picbxplayer3 = new PictureBox();
        PictureBox Picbxplayer4 = new PictureBox();
        Label lbldealer = new Label ();
        Label lblplayer1 = new Label ();
        Label lblplayer2 = new Label();
        Label lblplayer3 = new Label();
        Label lblplayer4 = new Label();

        int num_jugadores;



        public Form1()
        {
            InitializeComponent();     
        }
          
        private void Form1_Load(object sender, EventArgs e)
        {
            menu_inicio();     
        }

        //Al dar click al boton de un jugador se cargará la partida para un solo jugador si el usuario presiona OK en la messagebox;
        //caso contrario, regresa al menu
         private void btnoneplayer_Click(object sender, EventArgs e)
         {
             DialogResult Question = MessageBox.Show("¿Seguro de qué solo habrá un jugador en la partida?", "Blackjack", MessageBoxButtons.OKCancel);
             if(Question == DialogResult.OK)
             {
                 num_jugadores = 1;
                 borrar_menu();
                 pintar_mesa();
                 dealer();
                 posicion_de_jugador();
                 player1();
              
             }
           
         }

        //Al dar click al boton btntwoplayer se cargará la partida para dos jugadores si el usuario presiona OK en la messagebox
        //caso contrario, regresa al menu
         private void btntwoplayer_Click(object sender, EventArgs e)
         {
             DialogResult Question = MessageBox.Show("¿Seguro de qué habrá dos jugadores en la partida?", "Blackjack", MessageBoxButtons.OKCancel);
             if (Question == DialogResult.OK)
             {
                 num_jugadores = 2;
                 borrar_menu();
                 pintar_mesa();
                 dealer();
                 posicion_de_jugador();
                 player1 ();
                 player2 ();
               


                 
             }
         }
         //Al dar click al boton btntrheeplayer se cargará la partida para tres jugadores si el usuario presiona OK en la messagebox
         //caso contrario, regresa al menu
         private void btnthreeplayer_Click(object sender, EventArgs e)
         {

             DialogResult Question = MessageBox.Show("¿Seguro de qué habrá tres jugadores en la partida?", "Blackjack", MessageBoxButtons.OKCancel);
             if (Question == DialogResult.OK)
             {
                 num_jugadores = 3;
                 borrar_menu();
                 pintar_mesa();
                 dealer();
                 posicion_de_jugador();
                 player1();
                 player2();
                 player3();

             }
         }
         //Al dar click al boton btnfourplayer se cargará la partida para cuatro jugadores si el usuario presiona OK en la messagebox
         //caso contrario, regresa al menu
         private void btnfourplayer_click(object sender, EventArgs e)
         {
             DialogResult Question = MessageBox.Show("¿Seguro de qué habrá cuatro jugadores en la partida?", "Blackjack", MessageBoxButtons.OKCancel);
             if (Question == DialogResult.OK)
             {
                 num_jugadores = 4;
                 borrar_menu();
                 pintar_mesa();
                 dealer();
                 posicion_de_jugador();
                 player1();
                 player2();
                 player3();
                 player4();
             }
            
         }
         //Función que aparece un menú con las opciones de cuántos jugadores habrán en la partida
         void menu_inicio()
        { 
              
            //fondo del menu
            this.BackColor = System.Drawing.Color.Silver;
            
            //Titulo
            lbl_title.Height = 50;
            lbl_title.Width = 525;
            lbl_title.Text = ("¡Bienvenido al Juego del Black Jack!");
            lbl_title.Font = new Font ("Calibri", 25);
            lbl_title.Location = new Point(290, 30);
            Controls.Add(lbl_title);

            //Subtitulo
            
            lbl_subtitle.Height = 50;
            lbl_subtitle.Width = 525;
            lbl_subtitle.Text = ("¿Cuántos jugadores habrán en la partida?");
            lbl_subtitle.Font = new Font("Calibri", 19);
            lbl_subtitle.Location = new Point(310, 100);
            Controls.Add(lbl_subtitle);

            //logo izquierdo
            
            Picbx_left.Height = 150;
            Picbx_left.Width = 100;
            Picbx_left.Location = new Point(100,40);
            Picbx_left.Load(@"..\..\Menu\logo1.jpg");
            Picbx_left.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Picbx_left);

            //logo derecho
           
            Picbx_right.Height = 150;
            Picbx_right.Width = 100;
            Picbx_right.Location = new Point(840, 40);
            Picbx_right.Load(@"..\..\Menu\logo2.jpg");
            Picbx_right.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Picbx_right);

            
            //boton un jugador
            
            btnoneplayer.Height = 100;
            btnoneplayer.Width = 150;
            btnoneplayer.Text = ("Un jugador");
            btnoneplayer.Font = new Font("Arial", 16);
            btnoneplayer.Location = new Point(320, 200);
            btnoneplayer.BackColor = Color.Red;
            Controls.Add(btnoneplayer);

            //boton dos jugadores
            
            btntwoplayer.Height = 100;
            btntwoplayer.Width = 150;
            btntwoplayer.Text = ("Dos jugadores");
            btntwoplayer.Font = new Font("Arial", 16);
            btntwoplayer.Location = new Point(580, 200);
            btntwoplayer.BackColor = Color.WhiteSmoke;
            Controls.Add(btntwoplayer);

            //boton tres jugadores
            
            btnthreeplayer.Height = 100;
            btnthreeplayer.Width = 150;
            btnthreeplayer.Text = ("Tres jugadores");
            btnthreeplayer.Font = new Font("Arial", 16);
            btnthreeplayer.Location = new Point(320, 380);
            btnthreeplayer.BackColor = Color.WhiteSmoke;
            Controls.Add(btnthreeplayer);

            //boton cuatro jugadores
            
            btnfourplayer.Height = 100;
            btnfourplayer.Width = 150;
            btnfourplayer.Text = ("Cuatro jugadores");
            btnfourplayer.Font = new Font("Arial", 16);
            btnfourplayer.Location = new Point(580, 380);
            btnfourplayer.BackColor = Color.Red;
            Controls.Add(btnfourplayer);

            //Reproduce una canción mientras el menu está abierto
            try
            {
                MenuSong = new SoundPlayer(Application.StartupPath + @"\..\..\Music\menu_theme.wav");
                MenuSong.PlayLooping();
            }
            catch (Exception Ex)
            {

            }


            //Se crea un nuevo handler para btnoneplayer 
            btnoneplayer.Click += new EventHandler(btnoneplayer_Click);
            //Se crea un nuevo handler para btntwoplayer
            btntwoplayer.Click += new EventHandler(btntwoplayer_Click);
            //se crea un nuevo handler para btnthreeplayer
            btnthreeplayer.Click += new EventHandler(btnthreeplayer_Click);
             //se crea un nuevo handler para btnfourplayer
            btnfourplayer.Click += new EventHandler(btnfourplayer_click);
          }

        //la función dibuja la mesa de juego 
        void pintar_mesa()
        {
            //pintar "marco de madera"
            Graphics madera = this.CreateGraphics();
            Pen marron = new Pen(Color.SaddleBrown, 50);
            madera.DrawEllipse(marron, 220, 120, 600, 375);

            //pintar "tela" verde
            Graphics tela = this.CreateGraphics();
            Pen verde = new Pen(Color.Green, 180);
            tela.DrawEllipse(verde, 320, 220, 400, 175);
            
            //Se reproduce una canción mientras el juego está activo
            try
            {
              GameSong = new SoundPlayer(Application.StartupPath + @"\..\..\Music\game_theme.wav");
              GameSong.PlayLooping(); 
            }
            catch (Exception Ex)
            {

            }

        }
        
        //Función que hace invisibles y deshabilita los controles del menu
        void borrar_menu ()
        {
           btnoneplayer.Visible = false;
           btntwoplayer.Visible = false;
           btnthreeplayer.Visible = false;
           btnfourplayer.Visible = false;
           Picbx_left.Visible = false;
           Picbx_right.Visible = false;
           lbl_subtitle.Visible = false;
           lbl_title.Visible = false;
           btnoneplayer.Enabled = false;
           btntwoplayer.Enabled = false;
           btnthreeplayer.Enabled = false;
           btnfourplayer.Enabled = false;
           Picbx_left.Enabled = false;
           Picbx_right.Enabled = false;
           lbl_subtitle.Enabled = false;
           lbl_title.Enabled = false;
           MenuSong.Stop();
        }
        //Función que genera al dealer
        void dealer()
        {
           Picbxdealer.Height = 70;
           Picbxdealer.Width = 70;
           Picbxdealer.Location = new Point(470,25);
           Picbxdealer.Load(@"..\..\Players\dealer.jpg");
           Picbxdealer.SizeMode = PictureBoxSizeMode.StretchImage;
           Controls.Add(Picbxdealer);
           lbldealer.Height = 20;
           lbldealer.Width = 80;
           lbldealer.Location = new Point(482, 8);
           lbldealer.Text = ("Dealer");
           lbldealer.Font = new Font("Arial", 12);
           Controls.Add(lbldealer);
        }
        //Función que genera al jugador 1
        void player1()
        {
            Picbxplayer1.Height = 55;
            Picbxplayer1.Width = 55;
            Picbxplayer1.Load(@"..\..\Players\player1.jpg");
            Picbxplayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Picbxplayer1);
            lblplayer1.Height = 15;
            lblplayer1.Width = 80;
            lblplayer1.Text = ("Jugador 1");
            lblplayer1.Font = new Font("Arial", 9);
            Controls.Add(lblplayer1);
        }
        //función que genera al jugador 2
        void player2()
        {
            Picbxplayer2.Height = 55;
            Picbxplayer2.Width = 55;
            Picbxplayer2.Load(@"..\..\Players\player2.jpg");
            Picbxplayer2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Picbxplayer2);
            lblplayer2.Height = 15;
            lblplayer2.Width = 80;
            lblplayer2.Text = ("Jugador 2");
            lblplayer2.Font = new Font("Arial", 9);
            Controls.Add(lblplayer2);
        }
        //función que genera al jugador 3
        void player3()
        {
            Picbxplayer3.Height = 60;
            Picbxplayer3.Width = 60;
            Picbxplayer3.Load(@"..\..\Players\player3.jpg");
            Picbxplayer3.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Picbxplayer3);
            lblplayer3.Height = 15;
            lblplayer3.Width = 80;
            lblplayer3.Text = ("Jugador 3");
            lblplayer3.Font = new Font("Arial", 9);
            Controls.Add(lblplayer3);
        }
        //función que genera al jugador 4
        void player4()
        {
            Picbxplayer4.Height = 90;
            Picbxplayer4.Width = 90;
            Picbxplayer4.Load(@"..\..\Players\player4.jpg");
            Picbxplayer4.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Picbxplayer4);
            lblplayer4.Height = 15;
            lblplayer4.Width = 80;
            lblplayer4.Text = ("Jugador 4");
            lblplayer4.Font = new Font("Arial", 9);
            Controls.Add(lblplayer4);
        }
        //Función para determinar en qué posición estarán los jugadores
        void posicion_de_jugador()
        {
            if (num_jugadores == 1)
            { 
                Picbxplayer1.Location = new Point(485,640);
                lblplayer1.Location = new Point(487, 695);
            }
            if (num_jugadores == 2)
            {
                Picbxplayer1.Location = new Point(252, 640);
                lblplayer1.Location = new Point(257, 695);
                Picbxplayer2.Location = new Point(742, 640);
                lblplayer2.Location = new Point(747, 695);
            }
            if (num_jugadores == 3)
            {
                Picbxplayer1.Location = new Point(252, 640);
                lblplayer1.Location = new Point(257, 695);
                Picbxplayer2.Location = new Point(742, 640);
                lblplayer2.Location = new Point(747, 695);
                Picbxplayer3.Location = new Point(5, 300);
                lblplayer3.Location = new Point(5, 360);
            }
            if (num_jugadores == 4)
            {
                Picbxplayer1.Location = new Point(252, 640);
                lblplayer1.Location = new Point(257, 695);
                Picbxplayer2.Location = new Point(742, 640);
                lblplayer2.Location = new Point(747, 695);
                Picbxplayer3.Location = new Point(5, 300);
                lblplayer3.Location = new Point(5, 360);
                Picbxplayer4.Location = new Point(1005, 250);
                lblplayer4.Location = new Point(1010, 340);
            }


        }

           

        

           
        
        
     





    }
}

