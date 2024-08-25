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
    public partial class Form1 : Form
    {
        private Pokemon[] pokemons;
        private DatabaseHelper dbHelper = new DatabaseHelper();
      
        public Form1()
        {
            InitializeComponent();
           comboBoxPokemons.SelectedIndexChanged += comboBoxPokemons_SelectedIndexChanged;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarElementosComboBoxes();
            SetSelectedIndex(comboBox1, 0);
            SetSelectedIndex2(comboBoxPokemons, 0);
        }

        private void CargarElementosComboBoxes()
        {
            using (var connection = dbHelper.GetConnection())
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Pokemon", connection);
                using (var reader = command.ExecuteReader())
                {
                    var pokemonsList = new List<Pokemon>();
                    while (reader.Read())
                    {
                        var nombre = reader["Nombre"].ToString();
                        var tipo = reader["Tipo"].ToString();
                        var ataque = Convert.ToInt32(reader["Ataque"]);
                        var defensa = Convert.ToInt32(reader["Defensa"]);
                        var imageData = reader["Imagen"] as byte[];

                        Image imagen = null;
                        if (imageData != null)
                        {
                            using (var ms = new MemoryStream(imageData))
                            {
                                imagen = Image.FromStream(ms);
                            }
                        }

                        var pokemon = new Pokemon(nombre, tipo, ataque, defensa, imagen);
                        pokemonsList.Add(pokemon);
                    
                    }
                    pokemons = pokemonsList.ToArray();
                }
                connection.Close();
            }

           
            comboBoxPokemons.DataSource = null;  // Limpia los DataSource
            comboBoxPokemons.DataSource = pokemons;
            comboBoxPokemons.DisplayMember = "Nombre";

            comboBox1.DataSource = null;  // Limpia los DataSource
            comboBox1.DataSource = pokemons;
            comboBox1.DisplayMember = "Nombre";

        }

        private void comboBoxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                pictureBoxPokemon.Image = selectedPokemon.Imagen;  // Muestra la imagen en el PictureBox
                comboBox1.SelectedItem = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Pokemon selectedPokemon)
            {
                pictureBoxPokemon2.Image = selectedPokemon.Imagen;  // Muestra la imagen en el segundo PictureBox
                comboBoxPokemons.SelectedItem = 0;
            }

            

        }

        // Desactivar temporalmente el evento SelectedIndexChanged
        private void SetSelectedIndex(ComboBox comboBox, int index)
        {
                comboBox.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
                comboBox.SelectedIndex = index;
                comboBox.SelectedIndexChanged += comboBoxPokemons_SelectedIndexChanged;
            
        }

       private void SetSelectedIndex2(ComboBox comboBox2, int index2)
        {
            comboBox2.SelectedIndexChanged -= comboBoxPokemons_SelectedIndexChanged;
            comboBox2.SelectedIndex = index2;
            comboBox2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }


        public double CalcularDanio(int ataque, int defensa, double efectividad)
        {
            if (defensa == 0)
            {
                throw new DivideByZeroException("La defensa no puede ser cero.");
            }
            return 50 * ((ataque / (double)defensa) * efectividad);
        }

        private double ObtenerEfectividad(string tipoAtacante, string tipoDefensor)
        {
            // Diccionario para almacenar las relaciones de efectividad de los tipos
            var efectividad = new Dictionary<string, Dictionary<string, double>>
    {
        { "Fuego", new Dictionary<string, double>
            {
                { "Planta", 2.0 },  // Fuego es super efectivo contra Planta
                { "Agua", 0.5 },    // Fuego no es muy efectivo contra Agua
                { "Eléctrico", 1.0 }, // Efectividad neutral
                { "Fuego", 1.0 }    // Fuego es neutral contra Fuego
            }
        },
        { "Agua", new Dictionary<string, double>
            {
                { "Planta", 0.5 },  // Agua no es muy efectivo contra Planta
                { "Fuego", 2.0 },   // Agua es super efectivo contra Fuego
                { "Eléctrico", 1.0 }, // Efectividad neutral
                { "Agua", 1.0 }    // Agua es neutral contra Agua
            }
        },
        { "Planta", new Dictionary<string, double>
            {
                { "Fuego", 0.5 },   // Planta no es muy efectivo contra Fuego
                { "Agua", 2.0 },    // Planta es super efectivo contra Agua
                { "Eléctrico", 1.0 }, // Efectividad neutral
                { "Planta", 1.0 }   // Planta es neutral contra Planta
            }
        },
        { "Eléctrico", new Dictionary<string, double>
            {
                { "Planta", 1.0 },  // Eléctrico es neutral contra Planta
                { "Fuego", 1.0 },   // Eléctrico es neutral contra Fuego
                { "Agua", 2.0 },    // Eléctrico es super efectivo contra Agua
                { "Eléctrico", 1.0 } // Eléctrico es neutral contra Eléctrico
            }
        }
    };

            // Valor predeterminado para la efectividad neutral
            double efectividadDefault = 1.0;

            // Verifica si el tipo del atacante y del defensor están en el diccionario
            if (efectividad.ContainsKey(tipoAtacante) && efectividad[tipoAtacante].ContainsKey(tipoDefensor))
            {
                return efectividad[tipoAtacante][tipoDefensor];
            }
            else
            {
                // Devuelve efectividad neutral si no se encuentra la combinación
                return efectividadDefault;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                // Definir tipo del Pokémon atacante
                string tipoAtacante = selectedPokemon.Tipo; // Suponiendo que el atacante es de tipo Fuego. Puedes ajustarlo según sea necesario.

                // Obtener tipo del Pokémon defensor desde la selección
                string tipoDefensor = selectedPokemon.Tipo;

                // Obtener otros valores necesarios
                int ataque = selectedPokemon.Ataque;
                int defensa = selectedPokemon.Defensa;

                // Obtener efectividad del ataque
                double efectividad = ObtenerEfectividad(tipoAtacante, tipoDefensor);

                // Calcular el daño
                double danio = CalcularDanio(ataque, defensa, efectividad);

                // Mostrar el resultado
                MessageBox.Show($"Daño del Ataque: {danio}\n" +
                    $"Efectividad del Ataque: {efectividad}");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un Pokémon.");
            }
        }

       

       //boton para agregar items al listbox
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedPokemon = (Pokemon)comboBoxPokemons.SelectedItem;
            if ( listBoxPlayerPokemons.Items.Count < 5)
            {
                listBoxPlayerPokemons.Items.Add(selectedPokemon);
            }
            else
            {
                MessageBox.Show("Puedes seleccionar hasta 5 Pokémon.");
            }
        }

        //boton para agregar items al listbox
        private void button3_Click(object sender, EventArgs e)
        {
            var selectedPokemon = (Pokemon)comboBox1.SelectedItem;
            if (listBoxPlayerPokemons2.Items.Count < 5)
            {
                listBoxPlayerPokemons2.Items.Add(selectedPokemon);
            }
            else
            {
                MessageBox.Show("Puedes seleccionar 5 Pokémons.");
            }
        }

        //BOton para limpiar los campos
        private void button_borrar_Click(object sender, EventArgs e)
        {
            listBoxPlayerPokemons.Items.Clear();
            listBoxPlayerPokemons2.Items.Clear();
            comboBoxPokemons.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ADD_Pokemon fb = new ADD_Pokemon();
            fb.Show();
        }

        private void pictureBoxPokemon2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is string imageUrl && !string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    pictureBoxPokemon2.Load(imageUrl);  // Carga la imagen desde la URL o ruta
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }
    }

    //constructor para almacenar datos y conseguir los datos de la base de datos
    public class Pokemon
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public Image Imagen { get; set; }

        public Pokemon(string nombre, string tipo, int ataque, int defensa, Image imagen)
        {
            Nombre = nombre;
            Tipo = tipo;
            Ataque = ataque;
            Defensa = defensa;
            Imagen = imagen;
        }
        public override string ToString()
        {
            return Nombre;
        }

    }

    //conecccion con la base de datos con una clase, asi es mas facil ya que podemos llamar la clase desde cualquier parte del codigo
    public class DatabaseHelper
    {
        private string connectionString = "Data Source= C:/Users/braul/OneDrive/Escritorio/Pokemon.db";

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

    }

}
