using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Pokebatalla
{
    public partial class ADD_Pokemon : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public ADD_Pokemon()
        {
            InitializeComponent();
 

        }

        private void ADD_Pokemon_Load(object sender, EventArgs e)
        {


        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string tipo = textBoxTipo.Text;
            int ataque;
            int defensa;

            // Validar ataque
            if (!int.TryParse(textBoxAtaque.Text, out ataque))
            {
                MessageBox.Show("El valor de ataque no es válido. Por favor, ingresa un número entero.");
                return;
            }

            // Validar defensa
            if (!int.TryParse(textBoxDefensa.Text, out defensa))
            {
                MessageBox.Show("El valor de defensa no es válido. Por favor, ingresa un número entero.");
                return;
            }

            Image imagen = pictureBoxImagen.Image;

            InsertPokemon(nombre, tipo, ataque, defensa, imagen);

            MessageBox.Show("Pokémon añadido exitosamente.");
            // Opcionalmente, puedes limpiar los controles después de guardar
            textBoxNombre.Clear();
            textBoxTipo.Clear();
            textBoxAtaque.Clear();
            textBoxDefensa.Clear();
            pictureBoxImagen.Image = null;
        }

        private void InsertPokemon(string nombre, string tipo, int ataque, int defensa, Image imagen)
        {
            using (var connection = dbHelper.GetConnection())
            {
                connection.Open();

                // Crear el comando SQL para insertar un nuevo Pokémon
                var command = new SQLiteCommand("INSERT INTO Pokemon (Nombre, Tipo, Ataque, Defensa, Imagen) VALUES (@Nombre, @Tipo, @Ataque, @Defensa, @Imagen)", connection);

                // Agregar parámetros para el comando SQL
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Tipo", tipo);
                command.Parameters.AddWithValue("@Ataque", ataque);
                command.Parameters.AddWithValue("@Defensa", defensa);

                if (imagen != null)
                {
                    // Convertir la imagen a un arreglo de bytes
                    using (var ms = new MemoryStream())
                    {
                        imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Puedes usar otro formato si es necesario
                        command.Parameters.AddWithValue("@Imagen", ms.ToArray());
                    }
                }
                else
                {
                    // Si no hay imagen, se puede almacenar NULL
                    command.Parameters.AddWithValue("@Imagen", DBNull.Value);
                }

                // Ejecutar el comando
                command.ExecuteNonQuery();
            }
        }

        private void buttonSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imágenes PNG|*.png|Imágenes JPEG|*.jpg;*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxImagen.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        public class DatabaseHelper
        {
            private string connectionString = "Data Source= C:/Users/braul/OneDrive/Escritorio/Pokemon.db";

            public SQLiteConnection GetConnection()
            {
                return new SQLiteConnection(connectionString);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fb = new Form1();
            this.Close();
            fb.Show();
            
        }
    }
}