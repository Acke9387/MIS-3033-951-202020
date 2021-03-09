using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for PokemonInfoWindow.xaml
    /// </summary>
    public partial class PokemonInfoWindow : Window
    {
        private PokemonInfoAPI Info { get; set; }

        private bool ShouldIShowTheFront { get; set; }

        public PokemonInfoWindow()
        {
            InitializeComponent();
        }

        public void PopulateWindow(PokemonInfoAPI info)
        {
            imgPokemon.Source = new BitmapImage(new Uri(info.SquigglyWorm.front_default));
            lblHeight.Content = $"Height: {info.height}";
            lblWeight.Content = $"Weight: {info.weight}";
            lblTitle.Content = info.name;
            ShouldIShowTheFront = false;
            Info = info;
        }

        private void btnDance_Click(object sender, RoutedEventArgs e)
        {
            if (ShouldIShowTheFront == true)
            {
                imgPokemon.Source = new BitmapImage(new Uri(Info.SquigglyWorm.front_default));
                //ShouldIShowTheFront = false;
            }
            else
            {
                imgPokemon.Source = new BitmapImage(new Uri(Info.SquigglyWorm.back_default));
                //ShouldIShowTheFront = true;
            }
            ShouldIShowTheFront = !ShouldIShowTheFront;
        }
    }
}
