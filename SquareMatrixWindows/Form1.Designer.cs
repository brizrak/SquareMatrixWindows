namespace SquareMatrixWindows
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            properties_panel = new Panel();
            properties_table_panel = new TableLayoutPanel();
            properties_table_panel_buton2 = new TableLayoutPanel();
            button_determinant_calculate = new Button();
            properties_table_panel_button1 = new TableLayoutPanel();
            button_create_matrix = new Button();
            properties_table_panel_numeric = new TableLayoutPanel();
            len_tbox = new TextBox();
            properties_table_panel_label = new TableLayoutPanel();
            label = new Label();
            panel_matrix_a = new Panel();
            panel_matrix_a_2 = new Panel();
            determinant_a_tbox = new TextBox();
            matrix_a_grid = new DataGridView();
            panel_matrix_b = new Panel();
            panel_matrix_b_2 = new Panel();
            determinant_b_tbox = new TextBox();
            matrix_b_grid = new DataGridView();
            panel_c = new Panel();
            panel_matrix_c_2 = new Panel();
            determinant_c_tbox = new TextBox();
            statusStrip1 = new StatusStrip();
            matrix_c_grid = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            properties_panel.SuspendLayout();
            properties_table_panel.SuspendLayout();
            properties_table_panel_buton2.SuspendLayout();
            properties_table_panel_button1.SuspendLayout();
            properties_table_panel_numeric.SuspendLayout();
            properties_table_panel_label.SuspendLayout();
            panel_matrix_a.SuspendLayout();
            panel_matrix_a_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matrix_a_grid).BeginInit();
            panel_matrix_b.SuspendLayout();
            panel_matrix_b_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matrix_b_grid).BeginInit();
            panel_c.SuspendLayout();
            panel_matrix_c_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matrix_c_grid).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(properties_panel, 0, 0);
            tableLayoutPanel1.Controls.Add(panel_matrix_a, 1, 0);
            tableLayoutPanel1.Controls.Add(panel_matrix_b, 0, 1);
            tableLayoutPanel1.Controls.Add(panel_c, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(927, 520);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // properties_panel
            // 
            properties_panel.BorderStyle = BorderStyle.FixedSingle;
            properties_panel.Controls.Add(properties_table_panel);
            properties_panel.Location = new Point(3, 3);
            properties_panel.Name = "properties_panel";
            properties_panel.Size = new Size(457, 254);
            properties_panel.TabIndex = 0;
            // 
            // properties_table_panel
            // 
            properties_table_panel.ColumnCount = 2;
            properties_table_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            properties_table_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            properties_table_panel.Controls.Add(properties_table_panel_buton2, 1, 2);
            properties_table_panel.Controls.Add(properties_table_panel_button1, 1, 1);
            properties_table_panel.Controls.Add(properties_table_panel_numeric, 0, 2);
            properties_table_panel.Controls.Add(properties_table_panel_label, 0, 1);
            properties_table_panel.Dock = DockStyle.Fill;
            properties_table_panel.Location = new Point(0, 0);
            properties_table_panel.Name = "properties_table_panel";
            properties_table_panel.RowCount = 4;
            properties_table_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            properties_table_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            properties_table_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            properties_table_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            properties_table_panel.Size = new Size(455, 252);
            properties_table_panel.TabIndex = 0;
            // 
            // properties_table_panel_buton2
            // 
            properties_table_panel_buton2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            properties_table_panel_buton2.ColumnCount = 1;
            properties_table_panel_buton2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            properties_table_panel_buton2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            properties_table_panel_buton2.Controls.Add(button_determinant_calculate, 0, 0);
            properties_table_panel_buton2.Dock = DockStyle.Fill;
            properties_table_panel_buton2.Location = new Point(230, 129);
            properties_table_panel_buton2.Name = "properties_table_panel_buton2";
            properties_table_panel_buton2.RowCount = 1;
            properties_table_panel_buton2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            properties_table_panel_buton2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            properties_table_panel_buton2.Size = new Size(222, 57);
            properties_table_panel_buton2.TabIndex = 3;
            // 
            // button_determinant_calculate
            // 
            button_determinant_calculate.Anchor = AnchorStyles.None;
            button_determinant_calculate.AutoSize = true;
            button_determinant_calculate.Location = new Point(33, 16);
            button_determinant_calculate.Name = "button_determinant_calculate";
            button_determinant_calculate.Size = new Size(156, 25);
            button_determinant_calculate.TabIndex = 0;
            button_determinant_calculate.Text = "Посчитать определители";
            button_determinant_calculate.UseVisualStyleBackColor = true;
            button_determinant_calculate.Click += button_determinant_calculate_Click;
            // 
            // properties_table_panel_button1
            // 
            properties_table_panel_button1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            properties_table_panel_button1.ColumnCount = 1;
            properties_table_panel_button1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            properties_table_panel_button1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            properties_table_panel_button1.Controls.Add(button_create_matrix, 0, 0);
            properties_table_panel_button1.Dock = DockStyle.Fill;
            properties_table_panel_button1.Location = new Point(230, 66);
            properties_table_panel_button1.Name = "properties_table_panel_button1";
            properties_table_panel_button1.RowCount = 1;
            properties_table_panel_button1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            properties_table_panel_button1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            properties_table_panel_button1.Size = new Size(222, 57);
            properties_table_panel_button1.TabIndex = 2;
            // 
            // button_create_matrix
            // 
            button_create_matrix.Anchor = AnchorStyles.None;
            button_create_matrix.AutoSize = true;
            button_create_matrix.Location = new Point(46, 16);
            button_create_matrix.Name = "button_create_matrix";
            button_create_matrix.Size = new Size(129, 25);
            button_create_matrix.TabIndex = 0;
            button_create_matrix.Text = "Построить матрицы";
            button_create_matrix.UseVisualStyleBackColor = true;
            button_create_matrix.Click += button_create_matrix_Click;
            // 
            // properties_table_panel_numeric
            // 
            properties_table_panel_numeric.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            properties_table_panel_numeric.ColumnCount = 1;
            properties_table_panel_numeric.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            properties_table_panel_numeric.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            properties_table_panel_numeric.Controls.Add(len_tbox, 0, 0);
            properties_table_panel_numeric.Dock = DockStyle.Fill;
            properties_table_panel_numeric.Location = new Point(3, 129);
            properties_table_panel_numeric.Name = "properties_table_panel_numeric";
            properties_table_panel_numeric.RowCount = 1;
            properties_table_panel_numeric.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            properties_table_panel_numeric.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            properties_table_panel_numeric.Size = new Size(221, 57);
            properties_table_panel_numeric.TabIndex = 1;
            // 
            // len_tbox
            // 
            len_tbox.Anchor = AnchorStyles.None;
            len_tbox.Location = new Point(35, 17);
            len_tbox.Name = "len_tbox";
            len_tbox.Size = new Size(150, 23);
            len_tbox.TabIndex = 0;
            len_tbox.Text = "2";
            len_tbox.TextAlign = HorizontalAlignment.Center;
            // 
            // properties_table_panel_label
            // 
            properties_table_panel_label.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            properties_table_panel_label.ColumnCount = 1;
            properties_table_panel_label.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            properties_table_panel_label.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            properties_table_panel_label.Controls.Add(label, 0, 0);
            properties_table_panel_label.Dock = DockStyle.Fill;
            properties_table_panel_label.Location = new Point(3, 66);
            properties_table_panel_label.Name = "properties_table_panel_label";
            properties_table_panel_label.RowCount = 1;
            properties_table_panel_label.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            properties_table_panel_label.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            properties_table_panel_label.Size = new Size(221, 57);
            properties_table_panel_label.TabIndex = 0;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.None;
            label.AutoSize = true;
            label.Location = new Point(22, 21);
            label.Name = "label";
            label.Size = new Size(177, 15);
            label.TabIndex = 0;
            label.Text = "Введите размерность матрицы";
            // 
            // panel_matrix_a
            // 
            panel_matrix_a.Controls.Add(panel_matrix_a_2);
            panel_matrix_a.Controls.Add(matrix_a_grid);
            panel_matrix_a.Location = new Point(466, 3);
            panel_matrix_a.Name = "panel_matrix_a";
            panel_matrix_a.Size = new Size(458, 254);
            panel_matrix_a.TabIndex = 1;
            // 
            // panel_matrix_a_2
            // 
            panel_matrix_a_2.BorderStyle = BorderStyle.FixedSingle;
            panel_matrix_a_2.Controls.Add(determinant_a_tbox);
            panel_matrix_a_2.Dock = DockStyle.Right;
            panel_matrix_a_2.Location = new Point(358, 0);
            panel_matrix_a_2.Name = "panel_matrix_a_2";
            panel_matrix_a_2.Size = new Size(100, 254);
            panel_matrix_a_2.TabIndex = 1;
            // 
            // determinant_a_tbox
            // 
            determinant_a_tbox.Location = new Point(3, 117);
            determinant_a_tbox.Name = "determinant_a_tbox";
            determinant_a_tbox.Size = new Size(92, 23);
            determinant_a_tbox.TabIndex = 0;
            determinant_a_tbox.TextAlign = HorizontalAlignment.Center;
            // 
            // matrix_a_grid
            // 
            matrix_a_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrix_a_grid.Dock = DockStyle.Left;
            matrix_a_grid.Location = new Point(0, 0);
            matrix_a_grid.Name = "matrix_a_grid";
            matrix_a_grid.RowTemplate.Height = 25;
            matrix_a_grid.Size = new Size(359, 254);
            matrix_a_grid.TabIndex = 0;
            // 
            // panel_matrix_b
            // 
            panel_matrix_b.Controls.Add(panel_matrix_b_2);
            panel_matrix_b.Controls.Add(matrix_b_grid);
            panel_matrix_b.Location = new Point(3, 263);
            panel_matrix_b.Name = "panel_matrix_b";
            panel_matrix_b.Size = new Size(457, 254);
            panel_matrix_b.TabIndex = 2;
            // 
            // panel_matrix_b_2
            // 
            panel_matrix_b_2.BorderStyle = BorderStyle.FixedSingle;
            panel_matrix_b_2.Controls.Add(determinant_b_tbox);
            panel_matrix_b_2.Dock = DockStyle.Right;
            panel_matrix_b_2.Location = new Point(357, 0);
            panel_matrix_b_2.Name = "panel_matrix_b_2";
            panel_matrix_b_2.Size = new Size(100, 254);
            panel_matrix_b_2.TabIndex = 2;
            // 
            // determinant_b_tbox
            // 
            determinant_b_tbox.Location = new Point(3, 115);
            determinant_b_tbox.Name = "determinant_b_tbox";
            determinant_b_tbox.Size = new Size(92, 23);
            determinant_b_tbox.TabIndex = 1;
            determinant_b_tbox.TextAlign = HorizontalAlignment.Center;
            // 
            // matrix_b_grid
            // 
            matrix_b_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrix_b_grid.Dock = DockStyle.Left;
            matrix_b_grid.Location = new Point(0, 0);
            matrix_b_grid.Name = "matrix_b_grid";
            matrix_b_grid.RowTemplate.Height = 25;
            matrix_b_grid.Size = new Size(359, 254);
            matrix_b_grid.TabIndex = 1;
            // 
            // panel_c
            // 
            panel_c.Controls.Add(panel_matrix_c_2);
            panel_c.Controls.Add(matrix_c_grid);
            panel_c.Location = new Point(466, 263);
            panel_c.Name = "panel_c";
            panel_c.Size = new Size(458, 254);
            panel_c.TabIndex = 3;
            // 
            // panel_matrix_c_2
            // 
            panel_matrix_c_2.BorderStyle = BorderStyle.FixedSingle;
            panel_matrix_c_2.Controls.Add(determinant_c_tbox);
            panel_matrix_c_2.Controls.Add(statusStrip1);
            panel_matrix_c_2.Dock = DockStyle.Right;
            panel_matrix_c_2.Location = new Point(358, 0);
            panel_matrix_c_2.Name = "panel_matrix_c_2";
            panel_matrix_c_2.Size = new Size(100, 254);
            panel_matrix_c_2.TabIndex = 2;
            // 
            // determinant_c_tbox
            // 
            determinant_c_tbox.Location = new Point(3, 115);
            determinant_c_tbox.Name = "determinant_c_tbox";
            determinant_c_tbox.Size = new Size(92, 23);
            determinant_c_tbox.TabIndex = 1;
            determinant_c_tbox.TextAlign = HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 230);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(98, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // matrix_c_grid
            // 
            matrix_c_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrix_c_grid.Dock = DockStyle.Left;
            matrix_c_grid.Location = new Point(0, 0);
            matrix_c_grid.Name = "matrix_c_grid";
            matrix_c_grid.RowTemplate.Height = 25;
            matrix_c_grid.Size = new Size(359, 254);
            matrix_c_grid.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 544);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            properties_panel.ResumeLayout(false);
            properties_table_panel.ResumeLayout(false);
            properties_table_panel_buton2.ResumeLayout(false);
            properties_table_panel_buton2.PerformLayout();
            properties_table_panel_button1.ResumeLayout(false);
            properties_table_panel_button1.PerformLayout();
            properties_table_panel_numeric.ResumeLayout(false);
            properties_table_panel_numeric.PerformLayout();
            properties_table_panel_label.ResumeLayout(false);
            properties_table_panel_label.PerformLayout();
            panel_matrix_a.ResumeLayout(false);
            panel_matrix_a_2.ResumeLayout(false);
            panel_matrix_a_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matrix_a_grid).EndInit();
            panel_matrix_b.ResumeLayout(false);
            panel_matrix_b_2.ResumeLayout(false);
            panel_matrix_b_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matrix_b_grid).EndInit();
            panel_c.ResumeLayout(false);
            panel_matrix_c_2.ResumeLayout(false);
            panel_matrix_c_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matrix_c_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
		private Panel properties_panel;
		private Panel panel_matrix_a;
		private Panel panel_matrix_b;
		private Panel panel_c;
		private DataGridView matrix_a_grid;
		private DataGridView matrix_b_grid;
		private DataGridView matrix_c_grid;
		private TableLayoutPanel properties_table_panel;
		private TableLayoutPanel properties_table_panel_buton2;
		private Button button_determinant_calculate;
		private TableLayoutPanel properties_table_panel_button1;
		private Button button_create_matrix;
		private TableLayoutPanel properties_table_panel_numeric;
		private TableLayoutPanel properties_table_panel_label;
		private Label label;
		private Panel panel_matrix_a_2;
		private Panel panel_matrix_c_2;
		private Panel panel_matrix_b_2;
		private TextBox len_tbox;
        private TextBox determinant_a_tbox;
        private TextBox determinant_b_tbox;
        private TextBox determinant_c_tbox;
        private StatusStrip statusStrip1;
    }
}