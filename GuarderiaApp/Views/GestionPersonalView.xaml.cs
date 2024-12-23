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

namespace GuarderiaApp.Views
{
    public partial class GestionPersonalView : UserControl
    {
        public GestionPersonalView()
        {
            InitializeComponent();
            CargarPersonal();
        }

        private void CargarPersonal()
        {
            // Simulación de datos
            var personal = new[]
            {
                new { IdPersonal = 1, NombreCompleto = "Ana García", Cargo = "Maestra", Telefono = "555-1234" },
                new { IdPersonal = 2, NombreCompleto = "Carlos López", Cargo = "Limpieza", Telefono = "555-5678" }
            };

            DataGridPersonal.ItemsSource = personal;
        }

        private void BtnAgregarPersonal_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Abrir ventana para agregar personal.", "Agregar Personal");
        }

        private void BtnEditarPersonal_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Abrir ventana para editar personal.", "Editar Personal");
        }

        private void BtnEliminarPersonal_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Eliminar personal seleccionado.", "Eliminar Personal");
        }
    }
}
