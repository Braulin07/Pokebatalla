namespace Pokebatalla
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxPokemons = new System.Windows.Forms.ComboBox();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBoxPokemon2 = new System.Windows.Forms.PictureBox();
            this.listBoxPlayerPokemons = new System.Windows.Forms.ListBox();
            this.listBoxPlayerPokemons2 = new System.Windows.Forms.ListBox();
            this.label_VS = new System.Windows.Forms.Label();
            this.botonAgregar1 = new System.Windows.Forms.Button();
            this.botonAgregar2 = new System.Windows.Forms.Button();
            this.button_borrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(313, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atacar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxPokemons
            // 
            this.comboBoxPokemons.FormattingEnabled = true;
            this.comboBoxPokemons.Location = new System.Drawing.Point(12, 273);
            this.comboBoxPokemons.Name = "comboBoxPokemons";
            this.comboBoxPokemons.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPokemons.TabIndex = 2;
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Location = new System.Drawing.Point(12, 24);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(228, 232);
            this.pictureBoxPokemon.TabIndex = 3;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(594, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBoxPokemon2
            // 
            this.pictureBoxPokemon2.Location = new System.Drawing.Point(498, 24);
            this.pictureBoxPokemon2.Name = "pictureBoxPokemon2";
            this.pictureBoxPokemon2.Size = new System.Drawing.Size(217, 232);
            this.pictureBoxPokemon2.TabIndex = 5;
            this.pictureBoxPokemon2.TabStop = false;
            this.pictureBoxPokemon2.Click += new System.EventHandler(this.pictureBoxPokemon2_Click);
            // 
            // listBoxPlayerPokemons
            // 
            this.listBoxPlayerPokemons.FormattingEnabled = true;
            this.listBoxPlayerPokemons.ItemHeight = 16;
            this.listBoxPlayerPokemons.Location = new System.Drawing.Point(246, 24);
            this.listBoxPlayerPokemons.Name = "listBoxPlayerPokemons";
            this.listBoxPlayerPokemons.Size = new System.Drawing.Size(120, 148);
            this.listBoxPlayerPokemons.TabIndex = 6;
            // 
            // listBoxPlayerPokemons2
            // 
            this.listBoxPlayerPokemons2.FormattingEnabled = true;
            this.listBoxPlayerPokemons2.ItemHeight = 16;
            this.listBoxPlayerPokemons2.Location = new System.Drawing.Point(372, 24);
            this.listBoxPlayerPokemons2.Name = "listBoxPlayerPokemons2";
            this.listBoxPlayerPokemons2.Size = new System.Drawing.Size(120, 148);
            this.listBoxPlayerPokemons2.TabIndex = 7;
            // 
            // label_VS
            // 
            this.label_VS.AutoSize = true;
            this.label_VS.BackColor = System.Drawing.Color.Transparent;
            this.label_VS.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VS.ForeColor = System.Drawing.Color.Red;
            this.label_VS.Location = new System.Drawing.Point(339, 111);
            this.label_VS.Name = "label_VS";
            this.label_VS.Size = new System.Drawing.Size(55, 39);
            this.label_VS.TabIndex = 8;
            this.label_VS.Text = "VS";
            // 
            // botonAgregar1
            // 
            this.botonAgregar1.Location = new System.Drawing.Point(139, 274);
            this.botonAgregar1.Name = "botonAgregar1";
            this.botonAgregar1.Size = new System.Drawing.Size(73, 24);
            this.botonAgregar1.TabIndex = 9;
            this.botonAgregar1.Text = "Agregar";
            this.botonAgregar1.UseVisualStyleBackColor = true;
            this.botonAgregar1.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonAgregar2
            // 
            this.botonAgregar2.Location = new System.Drawing.Point(515, 273);
            this.botonAgregar2.Name = "botonAgregar2";
            this.botonAgregar2.Size = new System.Drawing.Size(73, 24);
            this.botonAgregar2.TabIndex = 10;
            this.botonAgregar2.Text = "Agregar";
            this.botonAgregar2.UseVisualStyleBackColor = true;
            this.botonAgregar2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_borrar
            // 
            this.button_borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_borrar.ForeColor = System.Drawing.Color.Black;
            this.button_borrar.Location = new System.Drawing.Point(313, 303);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(104, 52);
            this.button_borrar.TabIndex = 11;
            this.button_borrar.Text = "Borrar";
            this.button_borrar.UseVisualStyleBackColor = false;
            this.button_borrar.Click += new System.EventHandler(this.button_borrar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(313, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "Agregar Pokemon";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 472);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_borrar);
            this.Controls.Add(this.botonAgregar2);
            this.Controls.Add(this.botonAgregar1);
            this.Controls.Add(this.label_VS);
            this.Controls.Add(this.listBoxPlayerPokemons2);
            this.Controls.Add(this.listBoxPlayerPokemons);
            this.Controls.Add(this.pictureBoxPokemon2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.comboBoxPokemons);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxPokemons;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBoxPokemon2;
        private System.Windows.Forms.ListBox listBoxPlayerPokemons;
        private System.Windows.Forms.ListBox listBoxPlayerPokemons2;
        private System.Windows.Forms.Label label_VS;
        private System.Windows.Forms.Button botonAgregar1;
        private System.Windows.Forms.Button botonAgregar2;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.Button button2;
    }
}

