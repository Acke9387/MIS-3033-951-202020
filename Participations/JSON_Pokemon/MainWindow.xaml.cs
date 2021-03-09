using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AllPokemonAPI api;
            string url = "https://pokeapi.co/api/v2/pokemon?limit=1200";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllPokemonAPI>(json);

            }

            foreach (ResultObject item in api.results.OrderBy(x => x.name).ToList())
            {
                lstPokemon.Items.Add(item);
            }

        }

        private void lstPokemon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ResultObject selectedPokemon = (ResultObject)lstPokemon.SelectedItem;
            PokemonInfoAPI info;
            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync(selectedPokemon.url).Result;

                info = JsonConvert.DeserializeObject<PokemonInfoAPI>(json);
            }

            PokemonInfoWindow wnd = new PokemonInfoWindow();
            wnd.PopulateWindow(info);
            wnd.ShowDialog();

        }
    }
}
