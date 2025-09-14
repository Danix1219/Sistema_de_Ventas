using System;
using System.Windows;
using System.Windows.Controls;

namespace Sistema_de_Ventas.Views.Inventario
{
    /// <summary>
    /// Lógica de interacción para Inventario_Screen.xaml
    /// </summary>
    public partial class Inventario_Screen : Page
    {
        public Inventario_Screen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void AgregarArticuloButton_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar el modal
            ModalOverlay.Visibility = Visibility.Visible;
        }

        private void CancelarModalButton_Click(object sender, RoutedEventArgs e)
        {
            // Ocultar el modal
            ModalOverlay.Visibility = Visibility.Collapsed;
        }
    }
}