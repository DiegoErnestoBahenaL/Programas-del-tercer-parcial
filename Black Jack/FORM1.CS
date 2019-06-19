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


        //controles de los personajes del  juego
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
       

        //Variables de los jugadores ( servirán para determinar sus posiciones)
        int dealer_x;
        int dealer_y;
        int player1_x;
        int player1_y;
        int player2_x;
        int player2_y;
        int player3_x;
        int player3_y;
        int player4_x;
        int player4_y;

        //variables de puntos
        int puntos_dealer;
        int puntos_jugador1;
        int puntos_jugador2;
        int puntos_jugador3;
        int puntos_jugador4;

    

        //Arreglo para la baraja
        int [] Baraja  = new int [] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52};
        int [] Baraja_puntos = new int []{0,2,3,4,5,6,7,8,9,10,10,10,10,0,2,3,4,5,6,7,8,9,10,10,10,10,0,2,3,4,5,6,7,8,9,10,10,10,10,0,2,3,4,5,6,7,8,9,10,10,10,10};
        int numero_random;

         Random numero_aleatorio = new Random();



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
                 //Se hace el primer reparto de cartas
                 DialogResult Conversation_first = MessageBox.Show("¿Listo? Si pierdes, ¡tu alma será mía!", "King Dice", MessageBoxButtons.OK);
                 if (Conversation_first == DialogResult.OK)
                 {
                     carta_aleatoria_dealer();
                     carta_aleatoria_jugador1();
                  
                  
                 }
                 DialogResult Conversation_second = MessageBox.Show("¡Comencemos!", "King Dice", MessageBoxButtons.OK);

                 if (Conversation_second == DialogResult.OK)
                 {
                     carta_aleatoria_dealer();
                     carta_aleatoria_jugador1();
                 }
                 //empieza el juego (situaciones iniciales: 21 o empate);
                 if (puntos_jugador1 == 21)
                 {
                   DialogResult Win = MessageBox.Show("Parece que me has ganado", "King Dice", MessageBoxButtons.OK);
                   puntos_1jugador();
                   puntos_jugador1 = 22;
                
                 }
                 //juego normal
                 while (puntos_jugador1 < 21)
                 {   
                     DialogResult Asking_for_card = MessageBox.Show("Llevas " +puntos_jugador1+" puntos ¿Quieres otra carta?", "King Dice", MessageBoxButtons.YesNo);

                     if (Asking_for_card== DialogResult.Yes)
                     {
                         carta_aleatoria_jugador1(); 
                         if (puntos_jugador1 > 21)
                         {
                           DialogResult Lose = MessageBox.Show("¡Has perdido!", "King Dice", MessageBoxButtons.OK);
                           puntos_1jugador();
                           break;
                    
                          }
                          if (puntos_jugador1 == 21)
                           {      
                             dealer_perdio();
                             puntos_1jugador();
                             break;  
                           }

                     }
                     if (Asking_for_card == DialogResult.No)
                     {
                
                         DialogResult Dealer_points = MessageBox.Show("veamos quién gana", "King Dice", MessageBoxButtons.OK);  
                         
                 if (puntos_dealer > puntos_jugador1 && puntos_dealer < 21)
                 {
                     DialogResult Dealerpoints = MessageBox.Show("Ja, parece que gané!", "King Dice", MessageBoxButtons.OK);
                     puntos_1jugador();
                 }
                 if (puntos_dealer == 21)
                 {
                     DialogResult Dealerpoints = MessageBox.Show("Ja, tu alma es mia!", "King Dice", MessageBoxButtons.OK);
                     puntos_1jugador();
                 }

                 if (puntos_dealer < puntos_jugador1 && puntos_dealer < 21)
                 {
                     DialogResult Dealerpoints = MessageBox.Show("Me has ganado!", "King Dice", MessageBoxButtons.OK);
                     puntos_1jugador();
                 }
                 if (puntos_jugador1 == puntos_dealer)
                 {
                     DialogResult Win = MessageBox.Show("Parece que es un empate", "King Dice", MessageBoxButtons.OK);
                     puntos_1jugador();
                        
                 }
                 break;
                     }
                
                  }
                 
              
             }
           
         }

         void dealer_perdio() 
         {
             DialogResult Win = MessageBox.Show("Parece que me has ganado", "King Dice", MessageBoxButtons.OK);
  
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
                 //Se hace el primer reparto de cartas
                 DialogResult Conversation_first = MessageBox.Show("¿Listos? Si pierden, ¡su alma será mía!", "King Dice", MessageBoxButtons.OK);
                 if (Conversation_first == DialogResult.OK)
                 {
                     carta_aleatoria_dealer();
                     carta_aleatoria_jugador1();
                     carta_aleatoria_jugador2();

                 }
                 DialogResult Conversation_second = MessageBox.Show("¡Comencemos!", "King Dice", MessageBoxButtons.OK);

                 if (Conversation_second == DialogResult.OK)
                 {
                     carta_aleatoria_dealer();
                     carta_aleatoria_jugador1();
                     carta_aleatoria_jugador2();
                 }
                 //empieza el juego (situaciones iniciales: 21 o empate);
                 if (puntos_jugador1 == 21 || puntos_jugador2 == 21)
                 {
                     DialogResult Win = MessageBox.Show("Parece que me han ganado", "King Dice", MessageBoxButtons.OK);
                     puntos_2jugadores();
                     puntos_jugador1 = 22;
                     puntos_jugador2 = 22;

                 }
                 //empieza el juego normal
              while (puntos_jugador1 < 21)
             {
                 DialogResult Asking_for_card = MessageBox.Show("Llevas " + puntos_jugador1 + " puntos ¿Quieres otra carta?", "King Dice", MessageBoxButtons.YesNo);

                 if (Asking_for_card == DialogResult.Yes)
                 {
                     carta_aleatoria_jugador1();
                     if (puntos_jugador1 > 21)
                     {
                         DialogResult Lose = MessageBox.Show("¡Has perdido!", "King Dice", MessageBoxButtons.OK);
                         puntos_2jugadores();
                         break;

                     }
                     if (puntos_jugador1 == 21)
                     {
                         dealer_perdio();
                         puntos_2jugadores();
                         puntos_jugador2 = 22;
                         break;
                     }
                 }
                 if (Asking_for_card == DialogResult.No)
                 {
                     DialogResult Dealer_points = MessageBox.Show("Pasemos al siguiente jugador", "King Dice", MessageBoxButtons.OK);
                     break;
                 }
             }
           
           
                  while (puntos_jugador2 < 21)
                  {
                      DialogResult Asking_for_card = MessageBox.Show("Llevas " + puntos_jugador2 + " puntos ¿Quieres otra carta?", "King Dice", MessageBoxButtons.YesNo);

                      if (Asking_for_card == DialogResult.Yes)
                      {
                          carta_aleatoria_jugador2();
                          if (puntos_jugador2 > 21)
                          {
                              DialogResult Lose = MessageBox.Show("¡Has perdido!", "King Dice", MessageBoxButtons.OK);
                              if ( puntos_jugador1>21 && puntos_jugador2>21)
                              {
                                  DialogResult dealerpoints = MessageBox.Show("Les he ganado!", "King Dice", MessageBoxButtons.OK);
                              }
                              puntos_2jugadores();

                              break;

                          }
                          if (puntos_jugador2 == 21)
                          {
                              dealer_perdio();
                              puntos_2jugadores();
                              break;
                          }
                      }
                      if (Asking_for_card == DialogResult.No)
                      {
                          DialogResult Dealer_points = MessageBox.Show("Veamos quien gana", "King Dice", MessageBoxButtons.OK);
                          if (puntos_dealer > puntos_jugador1 && puntos_dealer < 21 && puntos_dealer > puntos_jugador2 && puntos_dealer < 21)
                          {
                              DialogResult dealerpoints = MessageBox.Show("Ja, parece que gané!", "King Dice", MessageBoxButtons.OK);
                              puntos_2jugadores();
                          }
                          if (puntos_dealer == 21)
                          {
                              DialogResult dealerpoints = MessageBox.Show("Ja, su alma es mia!", "King Dice", MessageBoxButtons.OK);
                              puntos_2jugadores();
                          }

                          if (puntos_dealer < puntos_jugador1 && puntos_dealer < 21 || puntos_dealer < puntos_jugador2 && puntos_dealer < 21)
                          {
                              DialogResult dealerpoints = MessageBox.Show("Me han ganado!", "King Dice", MessageBoxButtons.OK);
                              puntos_2jugadores();
                          }
                          if (puntos_jugador1 == puntos_dealer || puntos_jugador2 == puntos_dealer)
                          {
                              DialogResult Win = MessageBox.Show("Parece que es un empate", "King Dice", MessageBoxButtons.OK);
                              puntos_2jugadores();

                          }
                          break;

                      }
                  }

              


                 
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
                 //Se hace el primer reparto de cartas
                 DialogResult Conversation_first = MessageBox.Show("¿Listos? Si pierden, ¡su alma será mía!", "King Dice", MessageBoxButtons.OK);
                 if (Conversation_first == DialogResult.OK)
                 {
                     carta_aleatoria_dealer();
                     carta_aleatoria_jugador1();
                     carta_aleatoria_jugador2();
                     carta_aleatoria_jugador3();
                 }
                 DialogResult Conversation_second = MessageBox.Show("¡Comencemos!", "King Dice", MessageBoxButtons.OK);

                 if (Conversation_second == DialogResult.OK)
                 {
                     carta_aleatoria_dealer();
                     carta_aleatoria_jugador1();
                     carta_aleatoria_jugador2();
                     carta_aleatoria_jugador3();
                 }
                 //situaciones iniciales
                 //empieza el juego (situaciones iniciales: 21 o empate);
                 if (puntos_jugador1 == 21 || puntos_jugador2 == 21 || puntos_jugador3 == 21)
                 {
                     DialogResult Win = MessageBox.Show("Parece que me han ganado", "King Dice", MessageBoxButtons.OK);
                     puntos_3jugadores();
                     puntos_jugador1 = 22;
                     puntos_jugador2 = 22;
                     puntos_jugador3 = 22;

                 }
        
                 //empieza juego normal
                 while (puntos_jugador1 < 21)
                 {
                     DialogResult Asking_for_card = MessageBox.Show("Llevas " + puntos_jugador1 + " puntos ¿Quieres otra carta?", "King Dice", MessageBoxButtons.YesNo);

                     if (Asking_for_card == DialogResult.Yes)
                     {
                         carta_aleatoria_jugador1();
                         if (puntos_jugador1 > 21)
                         {
                             DialogResult Lose = MessageBox.Show("¡Has perdido! Pasemos al siguiente jugador", "King Dice", MessageBoxButtons.OK);
                             puntos_3jugadores();
                             break;

                         }
                         if (puntos_jugador1 == 21)
                         {
                             dealer_perdio();
                             puntos_3jugadores();
                             puntos_jugador1 = 22;
                             break;
                         }
                     }
                     if (Asking_for_card == DialogResult.No)
                     {
                         DialogResult Dealer_points = MessageBox.Show("Pasemos al siguiente jugador", "King Dice", MessageBoxButtons.OK);
                         break;
                     }
                 }
                 while (puntos_jugador2 < 21)
                 {
                     DialogResult Asking_for_card = MessageBox.Show("Llevas " + puntos_jugador2 + " puntos ¿Quieres otra carta?", "King Dice", MessageBoxButtons.YesNo);

                     if (Asking_for_card == DialogResult.Yes)
                     {
                         carta_aleatoria_jugador2();
                         if (puntos_jugador2 > 21)
                         {
                             DialogResult Lose = MessageBox.Show("¡Has perdido! Pasemos al siguiente jugador", "King Dice", MessageBoxButtons.OK);
                             if (puntos_jugador1 > 21 && puntos_jugador2 > 21 && puntos_jugador3 > 21)
                             {
                                 DialogResult dealerpoints = MessageBox.Show("Les he ganado!", "King Dice", MessageBoxButtons.OK);
                             }
                             puntos_3jugadores();

                             break;

                         }
                         if (puntos_jugador2 == 21)
                         {
                             dealer_perdio();
                             puntos_3jugadores();
                             puntos_jugador2 = 22;
                             break;
                         }
                     }
                     if (Asking_for_card == DialogResult.No)
                     {
                         DialogResult Dealer_points = MessageBox.Show("Pasemos al siguiente jugador", "King Dice", MessageBoxButtons.OK);
                         break;

                     }
                 }
                 while (puntos_jugador3 < 21)
                 {
                     DialogResult Asking_for_card = MessageBox.Show("Llevas " + puntos_jugador3 + " puntos ¿Quieres otra carta?", "King Dice", MessageBoxButtons.YesNo);

                     if (Asking_for_card == DialogResult.Yes)
                     {
                         carta_aleatoria_jugador3();
                         if (puntos_jugador3 > 21)
                         {
                             DialogResult Lose = MessageBox.Show("¡Has perdido!", "King Dice", MessageBoxButtons.OK);
                             if (puntos_jugador1 > 21 && puntos_jugador2 > 21 && puntos_jugador3 >21)
                             {
                                 DialogResult dealerpoints = MessageBox.Show("Les he ganado!", "King Dice", MessageBoxButtons.OK);
                             }
                             if (puntos_jugador1 == puntos_jugador2 &&  puntos_dealer <puntos_jugador1)
                             {
                                 DialogResult dealerpoints = MessageBox.Show("Me han ganado", "King Dice", MessageBoxButtons.OK);
                             }
                             if ((puntos_jugador1 > puntos_dealer && puntos_jugador1 < 21) || (puntos_jugador2 > puntos_dealer && puntos_jugador2 < 21))
                             {
                                 DialogResult dealerpoints = MessageBox.Show("Me han ganado", "King Dice", MessageBoxButtons.OK);
                             }
                             puntos_3jugadores();

                             break;

                         }
                         if (puntos_jugador3 == 21)
                         {
                             DialogResult Win = MessageBox.Show("Parece que me has ganado", "King Dice", MessageBoxButtons.OK);
                             puntos_3jugadores();
                             break;
                         }
                     }
                     if (Asking_for_card == DialogResult.No)
                     {
                         DialogResult Dealer_points = MessageBox.Show("Veamos quien gana", "King Dice", MessageBoxButtons.OK);
                         if ((puntos_dealer > puntos_jugador1 && puntos_dealer < 21) && (puntos_dealer > puntos_jugador2 && puntos_dealer < 21) && (puntos_dealer > puntos_jugador3 && puntos_dealer < 21))
                         {
                             DialogResult dealerpoints = MessageBox.Show("Ja, parece que gané!", "King Dice", MessageBoxButtons.OK);
                             puntos_3jugadores();
                         }
                         if (puntos_dealer == 21)
                         {
                             DialogResult dealerpoints = MessageBox.Show("Ja, su alma es mia!", "King Dice", MessageBoxButtons.OK);
                             puntos_3jugadores();
                         }

                         if (puntos_dealer < puntos_jugador1 && puntos_dealer < 21 || puntos_dealer < puntos_jugador2 && puntos_dealer < 21 || puntos_dealer < puntos_jugador3 && puntos_dealer < 21)
                         {
                             DialogResult dealerpoints = MessageBox.Show("Me han ganado!", "King Dice", MessageBoxButtons.OK);
                             puntos_3jugadores();
                         }
                         if (puntos_jugador1 == puntos_dealer || puntos_jugador2 == puntos_dealer || puntos_jugador3 == puntos_dealer)
                         {
                             DialogResult Win = MessageBox.Show("Parece que es un empate", "King Dice", MessageBoxButtons.OK);
                             puntos_3jugadores();

                         }
                         break;

                     }
                 }


           
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
                 //Se hace el primer reparto de cartas
                 DialogResult Conversation_first = MessageBox.Show("¿Listos? Si pierden, ¡su alma será mía!", "King Dice", MessageBoxButtons.OK);
                 if (Conversation_first == DialogResult.OK)
                 {
                     carta_aleatoria_dealer();
                     carta_aleatoria_jugador1();
                     carta_aleatoria_jugador2();
                     carta_aleatoria_jugador3();
                     carta_aleatoria_jugador4();
                     
                 }
                 DialogResult Conversation_second = MessageBox.Show("¡Comencemos!", "King Dice", MessageBoxButtons.OK);

                 if (Conversation_second == DialogResult.OK)
                 {
                     carta_aleatoria_dealer();
                     carta_aleatoria_jugador1();
                     carta_aleatoria_jugador2();
                     carta_aleatoria_jugador3();
                     carta_aleatoria_jugador4();
                 }
                 //situaciones iniciales
                 //empieza el juego (situaciones iniciales: 21);
                 if (puntos_jugador1 == 21 || puntos_jugador2 == 21 || puntos_jugador3 == 21 || puntos_jugador4 == 21)
                 {
                     DialogResult Win = MessageBox.Show("Parece que me han ganado", "King Dice", MessageBoxButtons.OK);
                     puntos_4jugadores();
                     puntos_jugador1 = 22;
                     puntos_jugador2 = 22;
                     puntos_jugador3 = 22;
                     puntos_jugador4 = 22;
                 }
                 while (puntos_jugador1 < 21)
                 {
                     DialogResult Asking_for_card = MessageBox.Show("Llevas " + puntos_jugador1 + " puntos ¿Quieres otra carta?", "King Dice", MessageBoxButtons.YesNo);

                     if (Asking_for_card == DialogResult.Yes)
                     {
                         carta_aleatoria_jugador1();
                         if (puntos_jugador1 > 21)
                         {
                             DialogResult Lose = MessageBox.Show("¡Has perdido! Pasemos al siguiente jugador", "King Dice", MessageBoxButtons.OK);
                             puntos_4jugadores();
                             break;

                         }
                         if (puntos_jugador1 == 21)
                         {
                             dealer_perdio();
                             puntos_4jugadores();
                             puntos_jugador2 = 22;
                             puntos_jugador3 = 22;
                             puntos_jugador4 = 22;
                             break;
                         }
                     }
                     if (Asking_for_card == DialogResult.No)
                     {
                         DialogResult Dealer_points = MessageBox.Show("Pasemos al siguiente jugador", "King Dice", MessageBoxButtons.OK);
                         break;
                     }
                 }
                 while (puntos_jugador2 < 21)
                 {
                     DialogResult Asking_for_card = MessageBox.Show("Llevas " + puntos_jugador2 + " puntos ¿Quieres otra carta?", "King Dice", MessageBoxButtons.YesNo);

                     if (Asking_for_card == DialogResult.Yes)
                     {
                         carta_aleatoria_jugador2();
                         if (puntos_jugador2 > 21)
                         {
                             DialogResult Lose = MessageBox.Show("¡Has perdido! Pasemos al siguiente jugador", "King Dice", MessageBoxButtons.OK);
                             puntos_4jugadores();
                             break;
                         }
                         if (puntos_jugador2 == 21)
                         {
                             dealer_perdio();
                             puntos_4jugadores();
                             puntos_jugador3 = 22;
                             puntos_jugador4 = 22;
                             break;
                         }
                     }
                     if (Asking_for_card == DialogResult.No)
                     {
                         DialogResult Dealer_points = MessageBox.Show("Pasemos al siguiente jugador", "King Dice", MessageBoxButtons.OK);
                         break;

                     }
                 }
                 while (puntos_jugador3 < 21)
                 {
                     DialogResult Asking_for_card = MessageBox.Show("Llevas " + puntos_jugador3 + " puntos ¿Quieres otra carta?", "King Dice", MessageBoxButtons.YesNo);

                     if (Asking_for_card == DialogResult.Yes)
                     {
                         carta_aleatoria_jugador3();
                         if (puntos_jugador3 > 21)
                         {
                             DialogResult Lose = MessageBox.Show("¡Has perdido! Pasemos al siguiente jugador", "King Dice", MessageBoxButtons.OK);
                             puntos_4jugadores();
                             break;
                         }
                         if (puntos_jugador3 == 21)
                         {
                             dealer_perdio();
                             puntos_4jugadores();
                             puntos_jugador4 = 22;
                             break;
                         }
                     }
                     if (Asking_for_card == DialogResult.No)
                     {
                         DialogResult Dealer_points = MessageBox.Show("Pasemos al siguiente jugador", "King Dice", MessageBoxButtons.OK);
                         break;

                     }
                 }
                 while (puntos_jugador4 < 21)
                 {
                     DialogResult Asking_for_card = MessageBox.Show("Llevas " + puntos_jugador4 + " puntos ¿Quieres otra carta?", "King Dice", MessageBoxButtons.YesNo);

                     if (Asking_for_card == DialogResult.Yes)
                     {
                         carta_aleatoria_jugador4();
                         if (puntos_jugador4 > 21)
                         {
                             DialogResult Lose = MessageBox.Show("¡Has perdido!", "King Dice", MessageBoxButtons.OK);
                             if (puntos_jugador1 > 21 && puntos_jugador2 > 21 && puntos_jugador3 > 21)
                             {
                                 DialogResult dealerpoints = MessageBox.Show("Les he ganado!", "King Dice", MessageBoxButtons.OK);
                                 puntos_4jugadores();
                             }
                             if ((puntos_jugador1 == puntos_jugador2 && puntos_dealer < puntos_jugador1) || (puntos_jugador1 == puntos_jugador3 && puntos_dealer < puntos_jugador1) || (puntos_jugador3 == puntos_jugador2 && puntos_dealer < puntos_jugador3))
                             {
                                 DialogResult dealerpoints = MessageBox.Show("Me han ganado", "King Dice", MessageBoxButtons.OK);
                                 puntos_4jugadores();
                             }
                             if ((puntos_jugador1 > puntos_dealer && puntos_jugador1 < 21) || (puntos_jugador2 > puntos_dealer && puntos_jugador2 < 21) || (puntos_jugador3 > puntos_dealer && puntos_jugador2 < 21))
                             {
                                 DialogResult dealerpoints = MessageBox.Show("Me han ganado", "King Dice", MessageBoxButtons.OK);
                                 puntos_4jugadores();
                             }
                            

                             break;

                         }
                         if (puntos_jugador4 == 21)
                         {
                             DialogResult Win = MessageBox.Show("Parece que me has ganado, jefe", "King Dice", MessageBoxButtons.OK);
                             puntos_4jugadores();
                             break;
                         }
                     }
                     if (Asking_for_card == DialogResult.No)
                     {
                         DialogResult Dealer_points = MessageBox.Show("Veamos si me ganan", "King Dice", MessageBoxButtons.OK);
                         if ((puntos_dealer > puntos_jugador1 && puntos_dealer < 21) && (puntos_dealer > puntos_jugador2 && puntos_dealer < 21) && (puntos_dealer > puntos_jugador3 && puntos_dealer < 21) && (puntos_dealer > puntos_jugador4 && puntos_dealer < 21))
                         {
                             DialogResult dealerpoints = MessageBox.Show("Ja, parece que gané!", "King Dice", MessageBoxButtons.OK);
                             puntos_4jugadores();
                         }
                         if (puntos_dealer == 21)
                         {
                             DialogResult dealerpoints = MessageBox.Show("Ja, su alma es mia!", "King Dice", MessageBoxButtons.OK);
                             puntos_4jugadores();
                         }

                         if (puntos_dealer < puntos_jugador1 && puntos_jugador1 < 21 || puntos_dealer < puntos_jugador2 && puntos_jugador2 < 21 || puntos_dealer < puntos_jugador3 && puntos_jugador3 < 21 || puntos_dealer < puntos_jugador4 && puntos_jugador4 < 21)
                         {
                             DialogResult dealerpoints = MessageBox.Show("Me han ganado!", "King Dice", MessageBoxButtons.OK);
                             puntos_4jugadores();
                         }
                         if (puntos_jugador1 == puntos_dealer || puntos_jugador2 == puntos_dealer || puntos_jugador3 == puntos_dealer || puntos_jugador4 == puntos_dealer)
                         {
                             DialogResult Win = MessageBox.Show("Parece que es un empate", "King Dice", MessageBoxButtons.OK);
                             puntos_4jugadores();

                         }
                         break;

                     }
                 }

          
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
        //fUNCIÓN que hace visible el menu
        void rehacer_menu()
        {
            btnoneplayer.Visible = true;
            btntwoplayer.Visible = true;
            btnthreeplayer.Visible = true;
            btnfourplayer.Visible = true;
            Picbx_left.Visible = true;
            Picbx_right.Visible = true;
            lbl_subtitle.Visible = true;
            lbl_title.Visible = true;
            btnoneplayer.Enabled = true;
            btntwoplayer.Enabled = true;
            btnthreeplayer.Enabled = true;
            btnfourplayer.Enabled = true;
            Picbx_left.Enabled = true;
            Picbx_right.Enabled = true;
            lbl_subtitle.Enabled = true;
            lbl_title.Enabled = true;
           
        }





        //Función que genera al dealer
        void dealer()
        {
           dealer_x = 470;
           dealer_y = 25;
           Picbxdealer.Height = 70;
           Picbxdealer.Width = 70;
           Picbxdealer.Location = new Point(dealer_x,dealer_y);
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
            lblplayer1.Text = ("Cuphead");
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
            lblplayer2.Text = ("Mugman");
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
            lblplayer3.Text = ("Elder Kettle");
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
            lblplayer4.Text = ("Devil");
            lblplayer4.Font = new Font("Arial", 9);
            Controls.Add(lblplayer4); 
          
        
        
       
       
        }
        //Función para determinar en qué posición estarán los jugadores
        void posicion_de_jugador()
        {
            //Posición para un jugador
            if (num_jugadores == 1)
            { 
                //Coordenadas para player 1 y su label
                player1_x = 485;
                player1_y = 640;
                Picbxplayer1.Location = new Point(player1_x,player1_y);
                lblplayer1.Location = new Point(player1_x + 2, player1_y + 55);
            }
            //Posicion para dos jugadores
            if (num_jugadores == 2)
            {
                //Coordenadas para player1 y su label
                player1_x = 742;
                player1_y = 640;
                Picbxplayer1.Location = new Point(player1_x, player1_y);
                lblplayer1.Location = new Point(player1_x + 5 , player1_y + 55);
                //coordenadas para player2 y su label
                player2_x = 252;
                player2_y = 640;
                Picbxplayer2.Location = new Point(player2_x,player2_y);
                lblplayer2.Location = new Point(player2_x + 5, player2_y + 55);
            }
            //posición para tres jugadores
            if (num_jugadores == 3)
            {
                //Coordenadas para player1 y su label
                player1_x = 990;
                player1_y = 250;
                Picbxplayer1.Location = new Point(player1_x, player1_y);
                lblplayer1.Location = new Point(player1_x + 5, player1_y + 55);
                //coordenadas para player2 y su label
                player2_x = 742;
                player2_y = 640;
                Picbxplayer2.Location = new Point(player2_x, player2_y);
                lblplayer2.Location = new Point(player2_x + 5, player2_y + 55);
                //Coordenadas para player3 y su label
                player3_x = 252;
                player3_y = 640;
                Picbxplayer3.Location = new Point(player3_x, player3_y);
                lblplayer3.Location = new Point(player3_x, player3_y + 60);
            }
            //posiciones para tres jugadores
            if (num_jugadores == 4)
            {
                //Coordenadas para player1 y su label
                player1_x = 1005;
                player1_y = 250;
                Picbxplayer1.Location = new Point(player1_x, player1_y);
                lblplayer1.Location = new Point(player1_x + 5, player1_y + 55);
                //coordenadas para player2 y su label
                player2_x = 742;
                player2_y = 640;
                Picbxplayer2.Location = new Point(player2_x, player2_y);
                lblplayer2.Location = new Point(player2_x + 5, player2_y + 55);
                //Coordenadas para player3 y su label
                player3_x = 252;
                player3_y = 640;
                Picbxplayer3.Location = new Point(player3_x, player3_y);
                lblplayer3.Location = new Point(player3_x, player3_y + 60);
                //Coordenadas para player4 y su label
                player4_x = 5;
                player4_y = 300;
                Picbxplayer4.Location = new Point(player4_x, player4_y);
                lblplayer4.Location = new Point(player4_x + 5, player4_y + 90);
            }


        }
        //función que genera la carta del jugador 1 dependiendo del numero aleatorio generado por la función "random" y cuyo resultado es reflejado en numero_random
        void CartaDealer() 
        {  
            PictureBox PicbxCarddealer = new PictureBox();
            PicbxCarddealer.Height = 70;
            PicbxCarddealer.Width = 47;
            PicbxCarddealer.Location = new Point(dealer_x - 50, dealer_y + 90);
            PicbxCarddealer.Load(@"..\..\Cards\" + numero_random + ".jpg");
            PicbxCarddealer.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(PicbxCarddealer);
        }
        void CartaPlayer1()
        {
            PictureBox PicbxCardplayer1 = new PictureBox();
            PicbxCardplayer1.Height = 70;
            PicbxCardplayer1.Width = 47;
            PicbxCardplayer1.Location = new Point(player1_x - 50,player1_y-70);
            PicbxCardplayer1.Load(@"..\..\Cards\"+numero_random  +".jpg");
            PicbxCardplayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(PicbxCardplayer1);
        }
        //función que genera la carta del jugador 2 dependiendo del numero aleatorio generado por la función "random" y cuyo resultado es reflejado en numero_random
        void CartaPlayer2()
        {
            PictureBox PicbxCardplayer2 = new PictureBox();
            PicbxCardplayer2.Height = 65;
            PicbxCardplayer2.Width = 43;
            PicbxCardplayer2.Location = new Point(player2_x, player2_y-70);
            PicbxCardplayer2.Load(@"..\..\Cards\" + numero_random + ".jpg");
            PicbxCardplayer2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(PicbxCardplayer2);
        }
        //función que genera la carta del jugador 3 dependiendo del numero aleatorio generado por la función "random" y cuyo resultado es reflejado en numero_random
        void CartaPlayer3()
        {PictureBox PicbxCardplayer3 = new PictureBox();
            PicbxCardplayer3.Height = 65;
            PicbxCardplayer3.Width = 43;
            PicbxCardplayer3.Location = new Point(player3_x, player3_y-70);
            PicbxCardplayer3.Load(@"..\..\Cards\" + numero_random + ".jpg");
            PicbxCardplayer3.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(PicbxCardplayer3);
        }
        //función que genera la carta del jugador 4 dependiendo del numero aleatorio generado por la función "random" y cuyo resultado es reflejado en numero_random
        void CartaPlayer4()
        {
            PictureBox PicbxCardplayer4 = new PictureBox();
            PicbxCardplayer4.Height = 65;
            PicbxCardplayer4.Width = 43;
            PicbxCardplayer4.Location = new Point(player4_x, player4_y-70);
            PicbxCardplayer4.Load(@"..\..\Cards\" + numero_random + ".jpg");
            PicbxCardplayer4.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(PicbxCardplayer4);
        }

        void random()
        {
           
            numero_random = numero_aleatorio.Next(1, 53);
        }

        //Función que hace que no se repitan las cartas dadas al jugador 1 y determina las nuevas posiciones de las cartas generadas
        void carta_aleatoria_jugador1()
        {
            random();
            if (Baraja[numero_random - 1] == 0)
            {
                while (Baraja[numero_random - 1] == 0)
                {
                    random();
                }
                CartaPlayer1();
                player1_x += 30;
                Baraja[numero_random - 1] = 0;
                
                if (Baraja_puntos[numero_random - 1] == 0)
                {
                    DialogResult As = MessageBox.Show("¿Cuánto Quieres que valga el As Cuphead?, si das Sí valdra 11, si das no valdrá 1", "King Dice", MessageBoxButtons.YesNo);
                    if (As == DialogResult.Yes)
                    {
                        puntos_jugador1 += 11;
                    }
                    if (As == DialogResult.No)
                    {
                        puntos_jugador1 += 1;
                    }
                }
                puntos_jugador1 += Baraja_puntos [numero_random - 1];
            }
            else
            {
                CartaPlayer1();
                player1_x += 30;
                Baraja[numero_random - 1] = 0;
                
                if (Baraja_puntos[numero_random - 1] == 0)
                {
                    DialogResult As = MessageBox.Show("¿Cuánto Quieres que valga el As Cuphead?, si das Sí valdra 11, si das no valdrá 1", "King Dice", MessageBoxButtons.YesNo);
                    if (As == DialogResult.Yes)
                    {
                        puntos_jugador1 += 11;
                    }
                    if (As == DialogResult.No)
                    {
                        puntos_jugador1 += 1;
                    }
                }
                puntos_jugador1 += Baraja_puntos [numero_random - 1];
            }
        }
        //función que genera las cartas dadas a jugador 2, determina sus posiciones  así como su valor 
        void carta_aleatoria_jugador2()
        {
            random();
            if (Baraja[numero_random - 1] == 0)
            {
                while (Baraja[numero_random - 1] == 0)
                {
                    random();
                }
                CartaPlayer2();
                player2_x += 30;
                Baraja[numero_random - 1] = 0;

                if (Baraja_puntos[numero_random - 1] == 0)
                {
                    DialogResult As = MessageBox.Show("¿Cuánto Quieres que valga el As Mugman?, si das Sí valdra 11, si das no valdrá 1", "King Dice", MessageBoxButtons.YesNo);
                    if (As == DialogResult.Yes)
                    {
                        puntos_jugador2 += 11;
                    }
                    if (As == DialogResult.No)
                    {
                        puntos_jugador2 += 1;
                    }
                }
                puntos_jugador2 += Baraja_puntos[numero_random - 1];
            }
            else
            {
                CartaPlayer2();
                player2_x += 30;
                Baraja[numero_random - 1] = 0;

                if (Baraja_puntos[numero_random - 1] == 0)
                {
                    DialogResult As = MessageBox.Show("¿Cuánto Quieres que valga el As Mugman?, si das Sí valdra 11, si das no valdrá 1", "King Dice", MessageBoxButtons.YesNo);
                    if (As == DialogResult.Yes)
                    {
                        puntos_jugador2 += 11;
                    }
                    if (As == DialogResult.No)
                    {
                        puntos_jugador2 += 1;
                    }
                }
                puntos_jugador2 += Baraja_puntos[numero_random - 1];
            }
        }
        //función que genera las cartas dadas a jugador 3, determina sus posiciones  así como su valor 
        void carta_aleatoria_jugador3()
        {
            random();
            if (Baraja[numero_random - 1] == 0)
            {
                while (Baraja[numero_random - 1] == 0)
                {
                    random();
                }
                CartaPlayer3();
                player3_x += 30;
                Baraja[numero_random - 1] = 0;

                if (Baraja_puntos[numero_random - 1] == 0)
                {
                    DialogResult As = MessageBox.Show("¿Cuánto Quieres que valga el As Elder Kettle?, si das Sí valdra 11, si das no valdrá 1", "King Dice", MessageBoxButtons.YesNo);
                    if (As == DialogResult.Yes)
                    {
                        puntos_jugador3 += 11;
                    }
                    if (As == DialogResult.No)
                    {
                        puntos_jugador3 += 1;
                    }
                }
                puntos_jugador3 += Baraja_puntos[numero_random - 1];
            }
            else
            {
                CartaPlayer3();
                player3_x += 30;
                Baraja[numero_random - 1] = 0;

                if (Baraja_puntos[numero_random - 1] == 0)
                {
                    DialogResult As = MessageBox.Show("¿Cuánto Quieres que valga el As Elder Kittle?, si das Sí valdra 11, si das no valdrá 1", "King Dice", MessageBoxButtons.YesNo);
                    if (As == DialogResult.Yes)
                    {
                        puntos_jugador3 += 11;
                    }
                    if (As == DialogResult.No)
                    {
                        puntos_jugador3 += 1;
                    }
                }
                puntos_jugador3 += Baraja_puntos[numero_random - 1];
            }
        }
        //función que genera las cartas dadas a jugador 3, determina sus posiciones  así como su valor 
        void carta_aleatoria_jugador4()
        {
            random();
            if (Baraja[numero_random - 1] == 0)
            {
                while (Baraja[numero_random - 1] == 0)
                {
                    random();
                }
                CartaPlayer4();
                player4_x += 30;
                Baraja[numero_random - 1] = 0;

                if (Baraja_puntos[numero_random - 1] == 0)
                {
                    DialogResult As = MessageBox.Show("¿Cuánto Quiere que valga el As, Jefe?, si das Sí valdra 11, si das no valdrá 1", "King Dice", MessageBoxButtons.YesNo);
                    if (As == DialogResult.Yes)
                    {
                        puntos_jugador4 += 11;
                    }
                    if (As == DialogResult.No)
                    {
                        puntos_jugador4 += 1;
                    }
                }
                puntos_jugador4 += Baraja_puntos[numero_random - 1];
            }
            else
            {
                CartaPlayer4();
                player4_x += 30;
                Baraja[numero_random - 1] = 0;

                if (Baraja_puntos[numero_random - 1] == 0)
                {
                    DialogResult As = MessageBox.Show("¿Cuánto Quieres que valga el As, Jefe?, si das Sí valdra 11, si das no valdrá 1", "King Dice", MessageBoxButtons.YesNo);
                    if (As == DialogResult.Yes)
                    {
                        puntos_jugador4 += 11;
                    }
                    if (As == DialogResult.No)
                    {
                        puntos_jugador4 += 1;
                    }
                }
                puntos_jugador4 += Baraja_puntos[numero_random - 1];
            }
        }



        //Función que hace que no se repitan las cartas dadas al dealer y determina las nuevas posiciones de las cartas generadas
        void carta_aleatoria_dealer()
        {
            random();

            if (Baraja[numero_random - 1] == 0)
            {
                while (Baraja[numero_random - 1] == 0)
                {
                    random();
                }
                CartaDealer();
                dealer_x += 30;
                Baraja[numero_random - 1] = 0;
               
                if (Baraja_puntos[ numero_random -1]==0 )
                {
                    puntos_dealer += 11;
                }
          
                puntos_dealer += Baraja_puntos[numero_random - 1];
 
            }
            else
            {
                CartaDealer();
                dealer_x += 30;
                Baraja[numero_random - 1] = 0;
                
                if (Baraja_puntos[numero_random - 1] == 0 )
                {
                    puntos_dealer += 11;
                }
                puntos_dealer += Baraja_puntos[numero_random - 1];
            }
          
        }
        //Función que escribe los resultados para 1 jugador sobre las puntaciones de la partida
         void puntos_1jugador()
        {
            string puntosjugador1 = Convert.ToString(puntos_jugador1);
            string puntosdealer = Convert.ToString(puntos_dealer);
            List<string> ListaPuntos = new List<string>() { "Cuphead "+ puntosjugador1, "dealer: " + puntosdealer };
            using (StreamWriter escribir = new StreamWriter(@"..\..\Files\Resultados.txt")) 
            {
                foreach (string x in ListaPuntos)
                {
                    escribir.WriteLine(x);
                }
            }
        }
         //Función que escribe los resultados para 1 jugador sobre las puntaciones de la partida
         void puntos_2jugadores()
         {
             string puntosjugador1 = Convert.ToString(puntos_jugador1);
             string puntosjugador2 = Convert.ToString(puntos_jugador2);
             string puntosdealer = Convert.ToString(puntos_dealer);
             List<string> ListaPuntos = new List<string>() { "Cuphead: " + puntosjugador1, "Mugman: " + puntosjugador2 , "dealer: " + puntosdealer };
             using (StreamWriter escribir = new StreamWriter(@"..\..\Files\Resultados.txt"))
             {
                 foreach (string x in ListaPuntos)
                 {
                     escribir.WriteLine(x);
                 }
             }
         }
         //Función que escribe los resultados para 1 jugador sobre las puntaciones de la partida
         void puntos_3jugadores()
         {
             string puntosjugador1 = Convert.ToString(puntos_jugador1);
             string puntosjugador2 = Convert.ToString(puntos_jugador2);
             string puntosjugador3 = Convert.ToString(puntos_jugador3);
             string puntosdealer = Convert.ToString(puntos_dealer);
             List<string> ListaPuntos = new List<string>() { "Cuphead: " + puntosjugador1, "Mugman: " + puntosjugador2, "Elder Kettle: " + puntosjugador3, "Dealer: " + puntosdealer };
             using (StreamWriter escribir = new StreamWriter(@"..\..\Files\Resultados.txt"))
             {
                 foreach (string x in ListaPuntos)
                 {
                     escribir.WriteLine(x);
                 }
             }
         }
         //Función que escribe los resultados para 1 jugador sobre las puntaciones de la partida
         void puntos_4jugadores()
         {
             string puntosjugador1 = Convert.ToString(puntos_jugador1);
             string puntosjugador2 = Convert.ToString(puntos_jugador2);
             string puntosjugador3 = Convert.ToString(puntos_jugador3);
             string puntosjugador4 = Convert.ToString(puntos_jugador4);
             string puntosdealer = Convert.ToString(puntos_dealer);
             List<string> ListaPuntos = new List<string>() { "Cuphead: " + puntosjugador1, "Mugman: " + puntosjugador2, "Elder Kettle: " + puntosjugador3,"Devil: "+ puntosjugador4 , "dealer:" + puntosdealer };
             using (StreamWriter escribir = new StreamWriter(@"..\..\Files\Resultados.txt"))
             {
                 foreach (string x in ListaPuntos)
                 {
                     escribir.WriteLine(x);
                 }
             }
         }

           

        

           
        
        
     





    }
}

