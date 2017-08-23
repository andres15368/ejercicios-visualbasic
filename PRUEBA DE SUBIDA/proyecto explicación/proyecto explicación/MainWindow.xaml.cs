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

namespace proyecto_explicación
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[,] botones;
        private int numAciertos, numfallos;
        private const int alto = 4, ancho = 4;
        private int numero1, numero2;
        private int filanum, colnum;
        private DispatcherTimer tiempojuego;
        private Image[,] imagenes;
        private Grid[,] ph;
        private TextBlock[,] numeross;
        private System.Media.SoundPlayer sonido;

        public MainWindow()
        {
            sonido = new System.Media.SoundPlayer();
            sonido = new System.Media.SoundPlayer(proyecto_explicación.Properties.Resources.homero13);
            sonido.Load();
            sonido.Play();
            tiempojuego = new DispatcherTimer();
            tiempojuego.Tick += new EventHandler(segundosjuego);
            tiempojuego.Interval = new TimeSpan(0, 0, 1);
            tiempojuego.Start();
            numAciertos = 0;
            numfallos = 0;
            numero1 = -1;
            numero2 = -1;

            InitializeComponent();
            ph = new Grid[alto, ancho];
            imagenes = new Image[alto, ancho];
            numeross = new TextBlock[alto, ancho];
            botones = new Button[alto, ancho];
            num numero = new num();
            for (int i=0;i<alto;i++)
            {
                for (int j=0;j<ancho;j++)
                {
                    botones[i, j] = new Button();
                    botones[i, j].Click += clickBoton;
                    int nume = numero.obtenernumero();
                    botones[i, j].Foreground = new SolidColorBrush(Colors.Transparent);
                    Grid.SetColumn(botones[i, j], i);
                    Grid.SetRow(botones[i, j], j);
                    Pantalladejuego.Children.Add(botones[i,j]);
                    ph[i, j] = new Grid();
                    numeross[i, j] = new TextBlock();
                    numeross[i, j].Text = nume.ToString();
                    numeross[i, j].Visibility = Visibility.Collapsed;
                    botones[i, j].Content = ph[i, j];
                    imagenes[i, j] = new Image();
                    imagenes[i, j].Source = new BitmapImage(new Uri(numero.conseguirImagenes(nume), UriKind.Relative));
                    ph[i, j].Children.Add(imagenes[i, j]);
                   
                    imagenes[i, j].Visibility = Visibility.Collapsed;
                }
            }
        }

        private async void clickBoton(object sender,RoutedEventArgs e)
        {
            //cambia un tipo de objeto a un botón y cambiamos el color de la fuente;

            imagenes[Grid.GetColumn((Button)sender), Grid.GetRow((Button)sender)].Visibility = Visibility.Visible;
            if (numero1 ==-1)
            {
                numero1 = int.Parse(numeross[Grid.GetColumn((Button)sender), Grid.GetRow((Button)sender)].Text.ToString());
                colnum = Grid.GetColumn((Button)sender);
                filanum = Grid.GetRow((Button)sender);
            }
            else
            {
                numero2 = int.Parse(numeross[Grid.GetColumn((Button)sender), Grid.GetRow((Button)sender)].Text.ToString());
                await Task.Delay(1000);
                if (numero1 == numero2)
                {

                    numAciertos++;
                    Aciertos.Text = numAciertos.ToString();
                    ((Button)sender).IsEnabled = false;
                    MessageBox.Show("Ha acertado!!!");
                    botones[colnum, filanum].IsEnabled = false;
                }
                else
                {
                    sonido = new System.Media.SoundPlayer(proyecto_explicación.Properties.Resources.homero13);
                    sonido.Load();
                    sonido.Play();
                    numfallos++;
                    Fallidos.Text = numfallos.ToString();
                    
                    ((Button)sender).IsEnabled = true;
                    imagenes[Grid.GetColumn((Button)sender), Grid.GetRow((Button)sender)].Visibility = Visibility.Collapsed;
                    imagenes[colnum, filanum].Visibility = Visibility.Collapsed;
                    botones[colnum,filanum].IsEnabled = true;
                    MessageBox.Show("Ha fallado!!!");
                }
                numero1 = -1;
            }

            if (numAciertos== 8)
            {
                tiempojuego.Stop();
                MessageBox.Show(" Usted ha Ganado!!");
            }
        }

        private int segundos = 0;
        private void segundosjuego(object sender, EventArgs e)
        {
            Tiempo.Text = segundos.ToString();
            segundos++;
        }
    }
}
