using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace proyect
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[,] botnes;
        private int numACIERTOS, numFALLIDOS;
        private const int alto = 4, ancho = 4;
        private int numer1, numero2;
        private int filanum, colnum;
        private DispatcherTimer tiempojuego;
        private Image[,] IMAGENES;
        private Grid[,] ph;
        private TextBlock[,] numeross;


        public MainWindow()
        {
            tiempojuego = new DispatcherTimer();
            tiempojuego.Tick  += new EventHandler(segundojuego);
            tiempojuego.Interval = new TimeSpan(0, 0, 1);
            tiempojuego.Start();
            numACIERTOS = 0;
            numFALLIDOS = 0;
            numer1 = 0;
            numero2 = -1;

            InitializeComponent();
            ph = new Grid[alto, ancho];
            IMAGENES = new Image[alto, ancho];
            numeross = new TextBlock[alto, ancho];
            botnes = new Button[alto, ancho];
            numeros num = new numeros();
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    botnes[i, j] = new Button();
                    botnes[i, j].Click += clickBoton;
                    int numero = num.obtenernumeros();                  
                    botnes[i, j].Foreground = new SolidColorBrush(Colors.Transparent);
                    Grid.SetColumn(botnes[i, j], i);
                    Grid.SetRow(botnes[i, j], j);

                    pantalladejuego.Children.Add(botnes[i, j]);
                    ph[i, j] = new Grid();
                    numeross[i, j] = new TextBlock();
                    numeross[i, j].Text = numero.ToString();
                    numeross[i, j].Visibility = Visibility.Collapsed;
                    botnes[i, j].Content = ph[i, j];
                    IMAGENES[i, j] = new Image();
                    IMAGENES[i, j].Source = new BitmapImage(new Uri(num.conseguirimagenes(numero), UriKind.Relative));
                    ph[i, j].Children.Add(IMAGENES[i, j]);




                 



                }
            }

        }
        private async void clickBoton (object sender, RoutedEventArgs e)
        {
            //cambia de un tipo de objeto va boton y cambia el color de la fuente //
            ((Button)sender).Foreground = new SolidColorBrush(Colors.Red);
            ((Button)sender).IsEnabled = false;
            if (numer1==-1)

            {
                numer1 = int.Parse(((Button)sender).Content.ToString());
                colnum = Grid.GetColumn((Button)sender);
                filanum = Grid.GetRow((Button)sender);
            }
            else
            {
                numero2 = int.Parse(((Button)sender).Content.ToString());
                await Task.Delay(1000);

                if (numer1 == numero2)
                {
                    numACIERTOS++;
                    ACIERTOS.Text = numACIERTOS.ToString();
                    ((Button)sender).IsEnabled = false;
                    MessageBox.Show("usted acerto ");
                    botnes[colnum, filanum].IsEnabled = false;
                }
                else
                {
                    numFALLIDOS++;
                    FALLIDOS.Text = FALLIDOS.ToString();
                    botnes[colnum, filanum].Foreground = new SolidColorBrush(Colors.Transparent);
                    ((Button)sender).IsEnabled = true;
                    ((Button)sender).Foreground = new SolidColorBrush(Colors.Transparent);
                    botnes[ colnum,filanum].IsEnabled = true;
                    MessageBox.Show("Game Over");

                }
                numer1 = -1;
                
                 
                
                  }
            if (numACIERTOS==8)
            {
                tiempojuego.Stop();
                MessageBox.Show("USTED HA GANADO");

            }

             }
        private int segundos = 0;
        private  void segundojuego(object sender, EventArgs e)
        {
            TIEMPO.Text = segundos.ToString();
            segundos++;

        }

        }
    }

 