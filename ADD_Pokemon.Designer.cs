namespace Pokebatalla
{
    partial class ADD_Pokemon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_Pokemon));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.textBoxAtaque = new System.Windows.Forms.TextBox();
            this.textBoxDefensa = new System.Windows.Forms.TextBox();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.buttonSeleccionarImagen = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelAtaque = new System.Windows.Forms.Label();
            this.labelDefensa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(115, 40);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(147, 22);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(115, 89);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(147, 22);
            this.textBoxTipo.TabIndex = 4;
            // 
            // textBoxAtaque
            // 
            this.textBoxAtaque.Location = new System.Drawing.Point(115, 136);
            this.textBoxAtaque.Name = "textBoxAtaque";
            this.textBoxAtaque.Size = new System.Drawing.Size(147, 22);
            this.textBoxAtaque.TabIndex = 5;
            // 
            // textBoxDefensa
            // 
            this.textBoxDefensa.Location = new System.Drawing.Point(115, 185);
            this.textBoxDefensa.Name = "textBoxDefensa";
            this.textBoxDefensa.Size = new System.Drawing.Size(147, 22);
            this.textBoxDefensa.TabIndex = 6;
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(12, 219);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(250, 227);
            this.pictureBoxImagen.TabIndex = 7;
            this.pictureBoxImagen.TabStop = false;
            // 
            // buttonSeleccionarImagen
            // 
            this.buttonSeleccionarImagen.Location = new System.Drawing.Point(288, 250);
            this.buttonSeleccionarImagen.Name = "buttonSeleccionarImagen";
            this.buttonSeleccionarImagen.Size = new System.Drawing.Size(114, 48);
            this.buttonSeleccionarImagen.TabIndex = 8;
            this.buttonSeleccionarImagen.Text = "Seleccionar Imagen";
            this.buttonSeleccionarImagen.UseVisualStyleBackColor = true;
            this.buttonSeleccionarImagen.Click += new System.EventHandler(this.buttonSeleccionarImagen_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(288, 322);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(114, 50);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar Pokemon";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 47);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(22, 40);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(74, 20);
            this.label_Nombre.TabIndex = 11;
            this.label_Nombre.Text = "Nombre";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(22, 89);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(45, 20);
            this.labelTipo.TabIndex = 12;
            this.labelTipo.Text = "Tipo";
            // 
            // labelAtaque
            // 
            this.labelAtaque.AutoSize = true;
            this.labelAtaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtaque.Location = new System.Drawing.Point(22, 138);
            this.labelAtaque.Name = "labelAtaque";
            this.labelAtaque.Size = new System.Drawing.Size(67, 20);
            this.labelAtaque.TabIndex = 13;
            this.labelAtaque.Text = "Ataque";
            // 
            // labelDefensa
            // 
            this.labelDefensa.AutoSize = true;
            this.labelDefensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefensa.Location = new System.Drawing.Point(22, 187);
            this.labelDefensa.Name = "labelDefensa";
            this.labelDefensa.Size = new System.Drawing.Size(79, 20);
            this.labelDefensa.TabIndex = 14;
            this.labelDefensa.Text = "Defensa";
            // 
            // ADD_Pokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.labelDefensa);
            this.Controls.Add(this.labelAtaque);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonSeleccionarImagen);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.textBoxDefensa);
            this.Controls.Add(this.textBoxAtaque);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.textBoxNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADD_Pokemon";
            this.Text = "ADD_Pokemon";
            this.Load += new System.EventHandler(this.ADD_Pokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.TextBox textBoxAtaque;
        private System.Windows.Forms.TextBox textBoxDefensa;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button buttonSeleccionarImagen;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelAtaque;
        private System.Windows.Forms.Label labelDefensa;
    }
}