using System;
using System.Drawing;
using System.Windows.Forms;
using ValidadorDeContraseñas.Core;

namespace ValidadorDeContraseñasUI
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            txtContraseña.Text = "Ingrese su contraseña aquí";
            txtContraseña.ForeColor = Color.Gray;
            timerEslogan.Tick += TimerEslogan_Tick;
            timerEslogan.Start();

        }

        private void TimerEslogan_Tick(object sender, EventArgs e)
        {
            // Cambiar el color del Label al siguiente en el arcoíris
            lblEslogan.ForeColor = coloresArcoiris[indiceColor];

            // Mover al siguiente color, reiniciando si es necesario
            indiceColor = (indiceColor + 1) % coloresArcoiris.Length;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Obtener la contraseña desde el TextBox
            string contraseña = txtContraseña.Text;

            // Crear instancia del validador (usa el nombre completo)
            var validador = new ValidadorDeContraseñas.Core.ValidadorDeContraseñas();

            // Validar la contraseña
            var (esValida, mensaje) = validador.ValidarContraseña(contraseña);

            // Mostrar el resultado en el Label
            lblResultado.Text = mensaje;
            lblResultado.ForeColor = esValida ? System.Drawing.Color.Green : System.Drawing.Color.Red;

            // Cambiar imagen en PictureBox según la validez de la contraseña
            pbEstado.Image = esValida ? Properties.Resources.like : Properties.Resources.dislike;

            // Ajustar PictureBox
            pbEstado.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al tamaño del PictureBox
            pbEstado.Visible = true;

            // Asegurame de que sea visible después de validar
            lblResultado.Visible = true;
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingrese su contraseña aquí")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.Text = "Ingrese su contraseña aquí";
                txtContraseña.ForeColor = Color.Gray;
            }
        }

        private readonly Color[] coloresArcoiris = new Color[]
{
    Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet
};
        private int indiceColor = 0;

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            // Mostrar el lblResultado solo si el usuario escribe algo
            lblResultado.Visible = !string.IsNullOrWhiteSpace(txtContraseña.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           var confirmacion = MessageBox.Show(
        "¿Estás seguro de que deseas salir?",
        "Confirmar salida",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

    if (confirmacion == DialogResult.Yes)
    {
        Application.Exit();
    }
        }
    }
}

