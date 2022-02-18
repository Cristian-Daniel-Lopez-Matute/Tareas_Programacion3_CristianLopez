using System.Collections;

namespace Ejercicio2_CristianLopez_Lenguaje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList DatosEstudiantes = new ArrayList();

        private void IngresarDatosButton_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text =="")
            {
                errorProvider1.SetError(NombreTextBox, "Debe ingresar el nombre del estudiante");
                NombreTextBox.Focus();
                return;
            }
            errorProvider1.SetError(NombreTextBox,"");
            if (EdadTextBox.Text == "")
            {
                errorProvider1.SetError(EdadTextBox , "Debe ingresar la edad del estudiante");
                EdadTextBox.Focus();
                return;
            }
            errorProvider1.SetError(EdadTextBox, "");


            Estudiante estudiantes=new Estudiante();

            estudiantes.Nombre = NombreTextBox.Text;
            estudiantes.edad= Convert.ToInt32(EdadTextBox.Text);

            DatosEstudiantes.Add(estudiantes);

            DatosDataGridView.DataSource = null;
            DatosDataGridView.DataSource= DatosEstudiantes;
            limpiar();
        }

        private void limpiar()
        {
            NombreTextBox.Text = "";
            EdadTextBox.Text = "";
            NombreTextBox.Focus();
        }
    }
}