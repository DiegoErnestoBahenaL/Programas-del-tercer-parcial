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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Enter_character = new System.Windows.Forms.TextBox();
            this.search_character = new System.Windows.Forms.TextBox();
            this.characters_names = new System.Windows.Forms.ListBox();
            this.Character_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Character_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(641, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Seleccione un personaje";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Enter_character
            // 
            this.Enter_character.Location = new System.Drawing.Point(641, 106);
            this.Enter_character.Name = "Enter_character";
            this.Enter_character.Size = new System.Drawing.Size(266, 20);
            this.Enter_character.TabIndex = 1;
            this.Enter_character.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Enter_character.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // search_character
            // 
            this.search_character.Location = new System.Drawing.Point(268, 584);
            this.search_character.Name = "search_character";
            this.search_character.Size = new System.Drawing.Size(266, 20);
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
            this.Character_picture.Location = new System.Drawing.Point(248, 210);
            this.Character_picture.Name = "Character_picture";
            this.Character_picture.Size = new System.Drawing.Size(304, 326);
            this.Character_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Character_picture.TabIndex = 4;
            this.Character_picture.TabStop = false;
            this.Character_picture.Click += new System.EventHandler(this.Character_picture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 683);
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
    }
}

