using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryReservasLopez
{
    public partial class frmQuenaken : Form
    {

        // Arreglo de PictureBox para representar los asientos
        private PictureBox[,] asientos;
        public frmQuenaken()
        {
            InitializeComponent();
            CrearAsientos();
        }
        private void CrearAsientos()
        {
            const int numFilas = 8;
            const int numColumnas = 5;
            const int anchoAsiento = 30;
            const int altoAsiento = 30;
            const int margen = 5;

            asientos = new PictureBox[numFilas, numColumnas];

            // Definir la posición inicial de los PictureBox
            int posX = 20;
            int posY = 20;

            // Crear PictureBox para cada asiento
            for (int fila = 0; fila < numFilas; fila++)
            {
                for (int columna = 0; columna < numColumnas; columna++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.BackColor = Color.Green;
                    pictureBox.Size = new Size(anchoAsiento, altoAsiento);
                    pictureBox.Location = new Point(posX, posY);
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Tag = $"{fila + 1}-{columna + 1}"; // Guardar el número de asiento en el Tag
                    pictureBox.Click += PictureBox_Click;
                    asientos[fila, columna] = pictureBox; // Agregar el PictureBox al arreglo

                    // Agregar el PictureBox al formulario
                    Controls.Add(pictureBox);

                    // Mover la posición X para el próximo PictureBox
                    posX += anchoAsiento + margen;
                }

                // Restablecer la posición X y mover la posición Y para el próximo conjunto de PictureBox
                posX = 20;
                posY += altoAsiento + margen;
            }
        }
        private void CompletarDatosReserva(string asiento)
        {
            // Obtener los datos de reserva del PictureBox
            string[] datosReserva = asiento.Split('-');

            // Mostrar los datos de reserva en los TextBox
            txtNombre.Text = datosReserva[0];
            txtDni.Text = datosReserva[1];
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string asiento = pictureBox.Tag.ToString();

            if (pictureBox.BackColor == Color.Red)
            {
                // Si el asiento está reservado, completar los datos en los TextBox
                CompletarDatosReserva(asiento);
            }
            else
            {
                // Si el asiento no está reservado, reservarlo
                ReservarAsiento(pictureBox);
            }
        }

        private void ReservarAsiento(PictureBox pictureBox)
        {
            // Verificar si se han ingresado los datos del nombre y el DNI
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor, complete el nombre y el DNI para reservar un asiento.");
                return;
            }

            // Cambiar el color del PictureBox a rojo para indicar que está reservado
            pictureBox.BackColor = Color.Red;

            // Asignar los datos de reserva al PictureBox
            pictureBox.Tag = $"{txtNombre.Text}-{txtDni.Text}";

            // Limpiar los campos de texto después de reservar
            LimpiarCamposTexto();
        }

        private void MostrarDatosReserva(string asiento)
        {
            // Obtener los datos de reserva del PictureBox
            string[] datosReserva = asiento.Split('-');

            // Mostrar los datos de reserva en un mensaje
           // MessageBox.Show($"Asiento: {asiento}\nNombre: {datosReserva[0]}\nDNI: {datosReserva[1]}");
        }

        private bool ObtenerFilaColumna(string asiento, out int fila, out int columna)
        {
            fila = columna = 0;
            try
            {
                string[] partes = asiento.Split('-');
                fila = int.Parse(partes[0]) - 1;
                columna = int.Parse(partes[1]) - 1;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void LimpiarCamposTexto()
        {
            txtNombre.Text = "";
            txtDni.Text = "";
        }

       

        private void frmQuenaken_Load(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click_1(object sender, EventArgs e)
        {
            // Obtener el número de asiento ingresado en el TextBox txtAsiento
            string asiento = txtAsiento.Text.Trim();

            // Verificar si se han ingresado los datos del nombre y el DNI
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor, complete el nombre y el DNI para reservar un asiento.");
                return;
            }

            // Obtener la fila y columna del asiento
            int fila, columna;
            if (!ObtenerFilaColumna(asiento, out fila, out columna))
            {
                MessageBox.Show("El número de asiento ingresado no es válido.");
                return;
            }

            // Reservar el asiento correspondiente
            ReservarAsiento(asientos[fila, columna]);
        }
    }
}
