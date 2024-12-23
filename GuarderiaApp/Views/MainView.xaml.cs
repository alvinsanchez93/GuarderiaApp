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

namespace GuarderiaApp.Views
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void BtnGestionAlumnos_Click(object sender, RoutedEventArgs e)
        {
            // Cargar el UserControl de Gestión de Alumnos
            ContentArea.Content = new GestionAlumnosView();
        }

        private void BtnGestionPersonal_Click(object sender, RoutedEventArgs e)
        {
            // Cargar el UserControl de Gestión de Personal
            ContentArea.Content = new GestionPersonalView();
        }

        private void BtnGestionPagos_Click(object sender, RoutedEventArgs e)
        {
            // Cargar el UserControl de Gestión de Pagos
            ContentArea.Content = new GestionPagosView();
        }

        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            // Volver al LoginView
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Close();
        }
    }
}
