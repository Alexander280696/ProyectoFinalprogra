namespace sudoku_prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int[,] sudoku = GenerarSudoku();

            for (int fila = 0; fila < 9; fila++)
            {
                for (int col = 0; col < 9; col++)
                {
                    // Asignar el número generado en la celda
                    TableLayoutPanel table = tableLayoutPanel1;
                    TextBox cell = (TextBox)table.GetControlFromPosition(col, fila);
                    cell.Text = sudoku[fila, col].ToString();
                }
            }
        }

        // Método simple para generar un Sudoku predefinido
        private int[,] GenerarSudoku()
        {
            return new int[,]
            {
                { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
                { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
                { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
                { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
                { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
                { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
                { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
                { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
                { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
            };
        }
    }
}
