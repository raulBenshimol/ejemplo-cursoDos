using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miQuintaApp
{
    public partial class frmFormulario : Form
    {
        public frmFormulario()
        {
            //Hola Raul
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de abandonar la carga?" , "Confirmar salida" , MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;

            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string direccion = txtDireccion.Text;

            if ((apellido == "") || (nombre == "") || (edad == "") || (direccion == "")) 
            {
                MessageBox.Show("Para poder validar tiene que llemar el formulario...");
                return;
            }
            else
            {
                List<string> resultados = new List<string>();

                resultados.Add("Apellido y Nombre: " + apellido +" "+ nombre);
                resultados.Add("Edad: " + edad);
                resultados.Add("Direccion: " + direccion);

                txtResultado.Text = string.Join(Environment.NewLine, resultados);
                txtApellido.Text = string.Join(Environment.NewLine, "");
                txtNombre.Text = string.Join(Environment.NewLine, "");
                txtEdad.Text = string.Join(Environment.NewLine, "");
                txtDireccion.Text = string.Join(Environment.NewLine, "");

                if (txtApellido.Text == "")
                    txtApellido.BackColor = Color.White;
                if (txtNombre.Text == "")
                    txtNombre.BackColor = Color.White;
                if (txtEdad.Text == "")
                    txtEdad.BackColor = Color.White;
                if (txtDireccion.Text == "")
                    txtDireccion.BackColor = Color.White;



            }

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

    }

}