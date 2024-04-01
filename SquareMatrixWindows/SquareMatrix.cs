using System;

namespace a
{
	class SquareMatrix
	{

		private int n;
		public int[,]? matrix = null;

		public SquareMatrix()
		{
		}

		public void set_n(int n)
		{
			if (n > 1) this.n = n;
			else
			{
				MessageBox.Show(
				"Некорректное значение",
				"Ошибка",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error
				);
			}
		}

		public void MatrixConstruction()
		{
			this.matrix = new int[n, n];
			for (int i = 0; i < this.n; i++)
			{
				for (int j = 0; j < this.n; j++)
				{
					if (i == j)
					{
                        this.matrix[i, j] = this.n - i;
					}
					else
					{
                        this.matrix[i, j] = 0;
					}
				}
			}
		}

		public void MatrixConstructionB()
		{
			this.MatrixConstruction();
			for (int i = 0; i < this.n; i++)
			{
				for (int j = 0; j < this.n; j++)
				{
					if (i > j)
					{
                        this.matrix[i, j] = i + 1;
					}
					else if (i < j)
					{
						this.matrix[i, j] = j + 1;
					}
				}
			}
		}

		public void MatrixConstructionC()
		{
			this.MatrixConstruction();
			int[,] matrix_c = new int[this.n, this.n];
			for (int i = 0; i < this.n; i++)
			{
				for (int j = 0; j < this.n; j++)
				{
					matrix_c[i, j] = this.matrix[this.n - i - 1, j];
				}
			}
			this.matrix = (int[,])matrix_c.Clone();
		}

		public int DeterminantCalculate(in int[,] matrix)
		{
			int[,] minor = null;
			if (matrix.GetLength(0) == 1)
			{
				return matrix[0, 0];
			}
			else if (matrix.GetLength(0) == 2)
			{
				return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
			}
			else
			{
				int current_determinant = 0;
				for (int i = 0; i < matrix.GetLength(0); i++)
				{
					minor = CreateMinor(matrix, i);
					current_determinant += (int)Math.Pow(-1, (double)i) * matrix[0, i] * DeterminantCalculate(in minor);
				}
				return current_determinant;
			}
		}

		private int[,] CreateMinor(int[,] matrix, int l)
		{
			int[,] minor = new int[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
			for (int i = 1, i1 = 0; i < matrix.GetLength(0); i++, i1++)
			{
				for (int j = 0, j1 = 0; j < matrix.GetLength(0); j++)
				{
					if (j != l)
					{
						minor[i1, j1] = matrix[i, j];
						j1++;
					}
				}

			}
			return minor;
		}

		public void MapMatrix(DataGridView view)
		{
			view.ColumnCount = n;
			view.RowCount = n;
			for (int i = 0; i < this.n; i++)
			{
				for (int j = 0; j < this.n; j++)
				{
					view.Rows[i].Cells[j].Value = this.matrix[i, j];
				}
			}
			view.AutoResizeColumns();
			view.AutoResizeRows();
		}

	}
}