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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Sistema_de_Ventas.Views
{
    /// <summary>
    /// Lógica de interacción para Splash_Screen.xaml
    /// </summary>
    public partial class Splash_Screen : Window
    {
        private DispatcherTimer timer;
        private int progreso = 0;
        public Splash_Screen()
        {
            InitializeComponent();
            derechosReservados.Content = $"Derechos Reservadors ©{DateTime.Now.Year}";

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progreso++;

            BarraProgreso.Value = progreso;
            
            if(progreso >= 100)
            {
                timer.Stop();
                Nav_Screen navScreen = new Nav_Screen();
                navScreen.Show();
                this.Close();
            }
        }
    }
}
