namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbx_screen = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_multp = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_rest = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbx_screen
            // 
            this.txbx_screen.Location = new System.Drawing.Point(41, 28);
            this.txbx_screen.Name = "txbx_screen";
            this.txbx_screen.Size = new System.Drawing.Size(198, 20);
            this.txbx_screen.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_sum, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_result, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_dot, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_zero, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_rest, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_three, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_two, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_one, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_division, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_six, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_five, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_four, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_multp, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_nine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_eight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_seven, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 134);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_seven
            // 
            this.btn_seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_seven.Location = new System.Drawing.Point(3, 3);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(45, 27);
            this.btn_seven.TabIndex = 0;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_eight.Location = new System.Drawing.Point(54, 3);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(45, 27);
            this.btn_eight.TabIndex = 1;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.btn_eight_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_nine.Location = new System.Drawing.Point(105, 3);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(45, 27);
            this.btn_nine.TabIndex = 2;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.btn_nine_Click);
            // 
            // btn_multp
            // 
            this.btn_multp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_multp.Location = new System.Drawing.Point(156, 3);
            this.btn_multp.Name = "btn_multp";
            this.btn_multp.Size = new System.Drawing.Size(45, 27);
            this.btn_multp.TabIndex = 3;
            this.btn_multp.Text = "x";
            this.btn_multp.UseVisualStyleBackColor = true;
            // 
            // btn_four
            // 
            this.btn_four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_four.Location = new System.Drawing.Point(3, 36);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(45, 27);
            this.btn_four.TabIndex = 4;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.btn_four_Click);
            // 
            // btn_five
            // 
            this.btn_five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_five.Location = new System.Drawing.Point(54, 36);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(45, 27);
            this.btn_five.TabIndex = 5;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.btn_five_Click);
            // 
            // btn_six
            // 
            this.btn_six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_six.Location = new System.Drawing.Point(105, 36);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(45, 27);
            this.btn_six.TabIndex = 6;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.btn_six_Click);
            // 
            // btn_division
            // 
            this.btn_division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_division.Location = new System.Drawing.Point(156, 36);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(45, 27);
            this.btn_division.TabIndex = 7;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_one
            // 
            this.btn_one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_one.Location = new System.Drawing.Point(3, 69);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(45, 27);
            this.btn_one.TabIndex = 8;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // btn_two
            // 
            this.btn_two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_two.Location = new System.Drawing.Point(54, 69);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(45, 27);
            this.btn_two.TabIndex = 9;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // btn_three
            // 
            this.btn_three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_three.Location = new System.Drawing.Point(105, 69);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(45, 27);
            this.btn_three.TabIndex = 10;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.btn_three_Click);
            // 
            // btn_rest
            // 
            this.btn_rest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rest.Location = new System.Drawing.Point(156, 69);
            this.btn_rest.Name = "btn_rest";
            this.btn_rest.Size = new System.Drawing.Size(45, 27);
            this.btn_rest.TabIndex = 11;
            this.btn_rest.Text = "-";
            this.btn_rest.UseVisualStyleBackColor = true;
            // 
            // btn_zero
            // 
            this.btn_zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_zero.Location = new System.Drawing.Point(3, 102);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(45, 29);
            this.btn_zero.TabIndex = 12;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dot.Location = new System.Drawing.Point(54, 102);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(45, 29);
            this.btn_dot.TabIndex = 13;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_result
            // 
            this.btn_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_result.Location = new System.Drawing.Point(105, 102);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(45, 29);
            this.btn_result.TabIndex = 14;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sum.Location = new System.Drawing.Point(156, 102);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(45, 29);
            this.btn_sum.TabIndex = 15;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.Location = new System.Drawing.Point(112, 220);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(45, 29);
            this.btn_CE.TabIndex = 2;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txbx_screen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_screen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_rest;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_multp;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_CE;
    }
}

