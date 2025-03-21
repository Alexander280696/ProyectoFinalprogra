using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku_prueba
{
    public partial class sudokufacil : Form
    {
        private TextBox celdaSeleccionada = null;  // Para llevar un control de la celda seleccionada

        private int[,] sudokuSolution = new int[4, 4]
        {
        { 3, 1, 4, 2 },
        { 2, 4, 3, 1 },
        { 1, 3, 2, 4 },
        { 2, 2, 1, 3 }
        };
        public sudokufacil()
        {
            InitializeComponent();
            // Aquí deberías suscribirte a los eventos de clic de los cuadros de texto
            txtC1.Click += Celda_Click;
            txtC2.Click += Celda_Click;
            txtC3.Click += Celda_Click;
            txtC4.Click += Celda_Click;
            txtC5.Click += Celda_Click;
            txtC6.Click += Celda_Click;
            txtC7.Click += Celda_Click;
            txtC8.Click += Celda_Click;
            txtC9.Click += Celda_Click;
            txtC10.Click += Celda_Click;
            txtC11.Click += Celda_Click;
            txtC12.Click += Celda_Click;
            // Añadir más celdas si las hay
        }

        // Este método se ejecuta cuando una celda (cuadro de texto) es clickeada
        private void Celda_Click(object sender, EventArgs e)
        {
            // Primero limpiamos el borde de todas las celdas
            LimpiarSelección();

            // Cambiamos el borde de la celda seleccionada
            celdaSeleccionada = sender as TextBox;
            if (celdaSeleccionada != null)
            {
                celdaSeleccionada.BorderStyle = BorderStyle.Fixed3D;  // Establecer borde visible
            }
        }

        // Limpiar borde de todas las celdas
        private void LimpiarSelección()
        {
            txtC1.BorderStyle = BorderStyle.None;
            txtC2.BorderStyle = BorderStyle.None;
            txtC3.BorderStyle = BorderStyle.None;
            txtC4.BorderStyle = BorderStyle.None;
            txtC5.BorderStyle = BorderStyle.None;
            txtC6.BorderStyle = BorderStyle.None;
            txtC7.BorderStyle = BorderStyle.None;
            txtC8.BorderStyle = BorderStyle.None;
            txtC9.BorderStyle = BorderStyle.None;
            txtC10.BorderStyle = BorderStyle.None;
            txtC11.BorderStyle = BorderStyle.None;
            txtC12.BorderStyle = BorderStyle.None;
            // Añadir más celdas si las hay
        }

        // Método para asignar un valor a la celda seleccionada
        private void AsignarValor(TextBox txtBox, int valor)
        {
            if (txtBox != null && txtBox.Text == "")
            {
                txtBox.Text = valor.ToString();
            }
        }

        // Métodos para los botones de números
        private void btnNum1_Click(object sender, EventArgs e)
        {
            // Asignamos "1" a la celda seleccionada
            if (celdaSeleccionada != null)
            {
                AsignarValor(celdaSeleccionada, 1);
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            // Asignamos "2" a la celda seleccionada
            if (celdaSeleccionada != null)
            {
                AsignarValor(celdaSeleccionada, 2);
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            // Asignamos "3" a la celda seleccionada
            if (celdaSeleccionada != null)
            {
                AsignarValor(celdaSeleccionada, 3);
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            // Asignamos "4" a la celda seleccionada
            if (celdaSeleccionada != null)
            {
                AsignarValor(celdaSeleccionada, 4);
            }
        }

        // Método para eliminar el número de la celda seleccionada
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminamos el número de la celda seleccionada
            if (celdaSeleccionada != null)
            {
                celdaSeleccionada.Clear();
            }
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            // Recorrer todas las celdas
            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    // Obtener el valor de la celda en la solución
                    int valorCorrecto = sudokuSolution[fila, columna];

                    // Obtener el control del cuadro de texto correspondiente
                    TextBox txtBox = ObtenerCelda(fila, columna);

                    // Verificar si el valor de la celda coincide con la solución
                    if (txtBox != null && !string.IsNullOrEmpty(txtBox.Text) && int.Parse(txtBox.Text) != valorCorrecto)
                    {
                        // Si alguna celda coincide con la solución, mostramos un mensaje de error
                       
                        MessageBox.Show("¡Felicidades! Has resuelto el Sudoku.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            // Si todas las celdas no coinciden con la solución, mostramos un mensaje de éxito
            MessageBox.Show("¡El Sudoku no es correcto! Revisa las celdas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Este método mapea las celdas a su posición de acuerdo con las filas y columnas
        private TextBox ObtenerCelda(int fila, int columna)
        {
            // Asignamos el cuadro de texto adecuado según la fila y columna
            switch (fila)
            {
                case 0:
                    switch (columna)
                    {
                        case 0: return txtC1;
                        case 1: return txtC2;
                        case 2: return txtC3;
                        case 3: return txtC4;
                    }
                    break;
                case 1:
                    switch (columna)
                    {
                        case 0: return txtC5;
                        case 1: return txtC6;
                        case 2: return txtC7;
                        case 3: return txtC8;
                    }
                    break;
                case 2:
                    switch (columna)
                    {
                        case 0: return txtC9;
                        case 1: return txtC10;
                        case 2: return txtC11;
                        case 3: return txtC12;
                    }
                    break;
                case 3:
                    // Si tu tablero tiene más celdas, puedes añadirlas aquí
                    break;
            }
            return null;
        }

    }
}

