using System;
using System.IO;
using System.Net.Http;

using System.Text.Json.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;


namespace Consumo_de_APIs
{
    public partial class Form1 : Form
    {
        private HttpClient HttpClient = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonBus_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresa un nombre de Pokémon.");
                return;
            }

            try
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{nombre}";
                string respuesta = await HttpClient.GetStringAsync(url);

                var pokemon = System.Text.Json.JsonSerializer.Deserialize<PokemonResponse>(respuesta);

                labelNom.Text = $"Nombre: {nombre.ToUpper()}";

                if (dataGridView.Columns.Count == 0)
                {
                    dataGridView.Columns.Add("StatName", "Estadística");
                    dataGridView.Columns.Add("BaseStat", "Valor Base");
                }

                dataGridView.Rows.Clear();
                foreach (var stat in pokemon.Stats)
                {
                    dataGridView.Rows.Add(stat.Stat.Name.Normalize(), stat.BaseStat);
                }

                piturePokemon.Load(pokemon.Sprites.FrontDefault);
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("No se pudo conectar a la API.");
            }
            catch (JsonException)
            {
                MessageBox.Show("No se pudo interpretar la respuesta de la API.");
            }
            catch (Exception)
            {
                MessageBox.Show("El Pokémon no fue encontrado o ocurrió un error.");
            }
        }
        private async void btnClima_ClickAsync(object sender, EventArgs e)
        {
            string ciudad = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(ciudad))
            {
                MessageBox.Show("Ingresa una ciudad.");
                return;
            }

            try
            {
                string url = $"http://api.openweathermap.org/data/2.5/weather?q={ciudad}&units=metric&APPID=ca23b9e8af2da4e9b7927f71f061d0a5";
                string respuesta = await HttpClient.GetStringAsync(url);

                var clima = System.Text.Json.JsonSerializer.Deserialize<ClimaResponse>(respuesta);

                labelNom.Text = $"Ciudad: {clima.Name.ToUpper()}";
                piturePokemon.Image = null; 

                if (dataGridView.Columns.Count == 0)
                {
                    dataGridView.Columns.Add("StatName", "Estadística");
                    dataGridView.Columns.Add("BaseStat", "Valor Base");
                }

                dataGridView.Rows.Clear(); // Borra datos anteriores

                dataGridView.Rows.Add("Temperatura (°C)", clima.Main.Temp);
                dataGridView.Rows.Add("Humedad (%)", clima.Main.Humidity);
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("No se pudo conectar a la API.");
            }
            catch (JsonException)
            {
                MessageBox.Show("No se pudo interpretar la respuesta de la API.");
            }
            catch (Exception)
            {
                MessageBox.Show("La ciudad no fue encontrada o ocurrió un error.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            txtBuscar.Clear();
            labelNom.Text = " Nombre:";
            piturePokemon.Image = null;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string nombre = labelNom.Text.Trim();
            string estadisticas = "";
            
            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                if (!fila.IsNewRow)

                {
                    foreach (DataGridViewCell celda in fila.Cells)
                        estadisticas += (celda.Value?.ToString() ?? "") + "\t";
                    estadisticas += Environment.NewLine;
                    
                }
            }

            try
            {
                Application wordApp = new Application();
                Document doc = wordApp.Documents.Add();
                wordApp.Visible = false;

                doc.Content.Text = "Nombre: " + nombre + "\n\nEstadísticas:\n" + estadisticas;

                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "datos.docx");
                doc.SaveAs2(ruta);

                doc.Close();
                wordApp.Quit();

                MessageBox.Show("Documento Word guardado correctamente en Mis Documentos", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en Word: " + ex.Message);
            }
        }
        public class PokemonResponse
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("sprites")]
            public Sprites Sprites { get; set; }

            [JsonPropertyName("stats")]
            public StatEntry[] Stats { get; set; }
        }
        public class Sprites
        {
            [JsonPropertyName("front_default")]
            public string FrontDefault { get; set; }
        }
        public class StatEntry
        {
            [JsonPropertyName("base_stat")]
            public int BaseStat { get; set; }

            [JsonPropertyName("stat")]
            public StatName Stat { get; set; }
        }
        public class StatName
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }
        }
        public class ClimaResponse
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("main")]
            public MainWeather Main { get; set; }

            [JsonPropertyName("weather")]
            public StatEntry[] Stats { get; set; }
        }
        public class MainWeather
        {
            [JsonPropertyName("temp")]
            public double Temp { get; set; }

            [JsonPropertyName("humidity")]
            public int Humidity { get; set; }
        }
        public class WeatherDescription
        {
            [JsonPropertyName("description")]
            public string Description { get; set; }
        }



    }
}


