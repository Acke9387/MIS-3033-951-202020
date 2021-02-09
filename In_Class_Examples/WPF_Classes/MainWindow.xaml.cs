﻿using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPF_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Pet myPet = new Pet()
            {
                Breed = txtBreed.Text,
                Name = txtName.Text,
                PictureURL = txtPic.Text
            };
            //myPet.Breed = txtBreed.Text;

            lstPets.Items.Add(myPet);
        }

        private void lstPets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pet selectedPet = (Pet)lstPets.SelectedItem;
            Uri petURI = new Uri(selectedPet.PictureURL);
            BitmapImage pic = new BitmapImage(petURI);
            imgPet.Source = pic;

        }
    }
}
