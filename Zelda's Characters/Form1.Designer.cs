﻿namespace WindowsFormsApplication1
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
            this.Enter_character = new System.Windows.Forms.TextBox();
            this.search_character = new System.Windows.Forms.TextBox();
            this.characters_names = new System.Windows.Forms.ListBox();
            this.Character_picture = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Character_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(629, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Seleccione un personaje";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Enter_character
            // 
            this.Enter_character.Location = new System.Drawing.Point(629, 109);
            this.Enter_character.Name = "Enter_character";
            this.Enter_character.Size = new System.Drawing.Size(278, 20);
            this.Enter_character.TabIndex = 1;
            this.Enter_character.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Enter_character.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // search_character
            // 
            this.search_character.Location = new System.Drawing.Point(629, 504);
            this.search_character.Name = "search_character";
            this.search_character.Size = new System.Drawing.Size(278, 20);
            this.search_character.TabIndex = 2;
            this.search_character.TextChanged += new System.EventHandler(this.serch_character_TextChanged);
            this.search_character.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serch_character_KeyPress);
            // 
            // characters_names
            // 
            this.characters_names.FormattingEnabled = true;
            this.characters_names.Location = new System.Drawing.Point(36, 87);
            this.characters_names.Name = "characters_names";
            this.characters_names.Size = new System.Drawing.Size(120, 459);
            this.characters_names.TabIndex = 3;
            this.characters_names.SelectedIndexChanged += new System.EventHandler(this.characters_names_SelectedIndexChanged);
            this.characters_names.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.characters_names_KeyPress);
            // 
            // Character_picture
            // 
            this.Character_picture.Location = new System.Drawing.Point(249, 177);
            this.Character_picture.Name = "Character_picture";
            this.Character_picture.Size = new System.Drawing.Size(304, 326);
            this.Character_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Character_picture.TabIndex = 4;
            this.Character_picture.TabStop = false;
            this.Character_picture.Click += new System.EventHandler(this.Character_picture_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(629, 245);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 177);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(249, 329);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(304, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 40;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(935, 583);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Character_picture);
            this.Controls.Add(this.characters_names);
            this.Controls.Add(this.search_character);
            this.Controls.Add(this.Enter_character);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Character_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Enter_character;
        private System.Windows.Forms.TextBox search_character;
        private System.Windows.Forms.ListBox characters_names;
        private System.Windows.Forms.PictureBox Character_picture;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

