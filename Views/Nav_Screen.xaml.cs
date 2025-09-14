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

namespace Sistema_de_Ventas.Views
{
    /// <summary>
    /// Lógica de interacción para Nav_Screen.xaml
    /// </summary>
    public partial class Nav_Screen : Window
    {
        public Nav_Screen()
        {
            InitializeComponent();
            MainFrame.Navigate(new Ventas.Ventas_Screen());
        }

        private void Btn_Ventas_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Ventas.Ventas_Screen());
        }

        private void Btn_Inventario_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Inventario.Inventario_Screen());
        }
    }
}
