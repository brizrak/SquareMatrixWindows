using a;

namespace SquareMatrixWindows
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SquareMatrix matrix_a = new SquareMatrix();
		SquareMatrix matrix_b = new SquareMatrix();
		SquareMatrix matrix_c = new SquareMatrix();


		private void button_create_matrix_Click(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(len_tbox.Text);

            matrix_a.set_n(n);
			matrix_a.MatrixConstruction();
			matrix_a.MapMatrix(matrix_a_grid);

			matrix_b.set_n(n);
			matrix_b.MatrixConstructionB();
			matrix_b.MapMatrix(matrix_b_grid);

			matrix_c.set_n(n);
			matrix_c.MatrixConstructionC();
			matrix_c.MapMatrix(matrix_c_grid);
		}

		private void button_determinant_calculate_Click(object sender, EventArgs e)
		{
			determinant_a_tbox.Text = Convert.ToString(matrix_a.DeterminantCalculate(in matrix_a.matrix));
            determinant_b_tbox.Text = Convert.ToString(matrix_b.DeterminantCalculate(in matrix_b.matrix));
            determinant_c_tbox.Text = Convert.ToString(matrix_c.DeterminantCalculate(in matrix_c.matrix));

        }
	}
}