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
    public partial class GestionPagosView : UserControl
    {
        public GestionPagosView()
        {
            InitializeComponent();
            CargarPagos();
        }

        private void CargarPagos()
        {
            // Simulación de datos
            var pagos = new[]
            {
                new { IdPago = 1, Alumno = "Juan Pérez", FechaPago = "2024-01-15", Monto = 500.00, Estado = "Pagado" },
                new { IdPago = 2, Alumno = "María López", FechaPago = "2024-01-20", Monto = 450.00, Estado = "Pendiente" }
            };

            DataGridPagos.ItemsSource = pagos;
        }

        private void BtnRegistrarPago_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Abrir ventana para registrar un pago.", "Registrar Pago");
        }

        private void BtnEditarPago_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Abrir ventana para editar un pago.", "Editar Pago");
        }

        private void BtnEliminarPago_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Eliminar pago seleccionado.", "Eliminar Pago");
        }
    }
}
