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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_one = new System.Windows.Forms.Label();
            this.lbl_two = new System.Windows.Forms.Label();
            this.lbl_three = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_four = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_six = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbl_five = new System.Windows.Forms.Label();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.lbl_ms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Guardar palabra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_one
            // 
            this.lbl_one.AutoSize = true;
            this.lbl_one.Location = new System.Drawing.Point(66, 279);
            this.lbl_one.Name = "lbl_one";
            this.lbl_one.Size = new System.Drawing.Size(159, 13);
            this.lbl_one.TabIndex = 5;
            this.lbl_one.Text = "Número de palabras ingresadas:";
            // 
            // lbl_two
            // 
            this.lbl_two.AutoSize = true;
            this.lbl_two.Location = new System.Drawing.Point(232, 279);
            this.lbl_two.Name = "lbl_two";
            this.lbl_two.Size = new System.Drawing.Size(0, 13);
            this.lbl_two.TabIndex = 6;
            // 
            // lbl_three
            // 
            this.lbl_three.AutoSize = true;
            this.lbl_three.Location = new System.Drawing.Point(231, 279);
            this.lbl_three.Name = "lbl_three";
            this.lbl_three.Size = new System.Drawing.Size(19, 13);
            this.lbl_three.TabIndex = 8;
            this.lbl_three.Text = "----";
            this.lbl_three.Click += new System.EventHandler(this.lbl_three_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Comenzar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_four
            // 
            this.lbl_four.AutoSize = true;
            this.lbl_four.Location = new System.Drawing.Point(138, 49);
            this.lbl_four.Name = "lbl_four";
            this.lbl_four.Size = new System.Drawing.Size(13, 13);
            this.lbl_four.TabIndex = 10;
            this.lbl_four.Text = "0";
            this.lbl_four.Click += new System.EventHandler(this.lbl_four_Click);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_six
            // 
            this.lbl_six.AutoSize = true;
            this.lbl_six.Location = new System.Drawing.Point(173, 49);
            this.lbl_six.Name = "lbl_six";
            this.lbl_six.Size = new System.Drawing.Size(13, 13);
            this.lbl_six.TabIndex = 11;
            this.lbl_six.Text = "0";
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lbl_five
            // 
            this.lbl_five.AutoSize = true;
            this.lbl_five.Location = new System.Drawing.Point(208, 49);
            this.lbl_five.Name = "lbl_five";
            this.lbl_five.Size = new System.Drawing.Size(13, 13);
            this.lbl_five.TabIndex = 12;
            this.lbl_five.Text = "0";
            this.lbl_five.Click += new System.EventHandler(this.lbl_five_Click);
            // 
            // lbl_sec
            // 
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.Location = new System.Drawing.Point(157, 49);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(10, 13);
            this.lbl_sec.TabIndex = 13;
            this.lbl_sec.Text = ":";
            // 
            // lbl_ms
            // 
            this.lbl_ms.AutoSize = true;
            this.lbl_ms.Location = new System.Drawing.Point(192, 49);
            this.lbl_ms.Name = "lbl_ms";
            this.lbl_ms.Size = new System.Drawing.Size(10, 13);
            this.lbl_ms.TabIndex = 14;
            this.lbl_ms.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 327);
            this.Controls.Add(this.lbl_ms);
            this.Controls.Add(this.lbl_sec);
            this.Controls.Add(this.lbl_five);
            this.Controls.Add(this.lbl_six);
            this.Controls.Add(this.lbl_four);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_three);
            this.Controls.Add(this.lbl_two);
            this.Controls.Add(this.lbl_one);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_one;
        private System.Windows.Forms.Label lbl_two;
        private System.Windows.Forms.Label lbl_three;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_four;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_six;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbl_five;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Label lbl_ms;
    }
}

