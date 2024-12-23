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
    public partial class GestionAlumnosView : UserControl
    {
        public GestionAlumnosView()
        {
            InitializeComponent();
            CargarAlumnos();
        }

        private void CargarAlumnos()
        {
            // Simulación de datos
            var alumnos = new[]
            {
                new { IdAlumno = 1, NombreCompleto = "Juan Pérez", Edad = 5, Alergias = "Ninguna" },
                new { IdAlumno = 2, NombreCompleto = "María López", Edad = 4, Alergias = "Polen" }
            };

            DataGridAlumnos.ItemsSource = alumnos;
        }

        private void BtnAgregarAlumno_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Abrir ventana para agregar alumno.", "Agregar Alumno");
        }

        private void BtnEditarAlumno_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Abrir ventana para editar alumno.", "Editar Alumno");
        }

        private void BtnEliminarAlumno_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Eliminar alumno seleccionado.", "Eliminar Alumno");
        }
    }
}
