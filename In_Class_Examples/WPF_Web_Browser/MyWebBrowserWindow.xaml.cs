using System;
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

namespace WPF_Web_Browser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MyWebBrowserWindow : Window
    {
        public string Query { get; set; } // First way

        public MyWebBrowserWindow()
        {
            InitializeComponent();

            webGoogle.Navigate($"https://www.google.com");
        }

        // Second way
        public void Search(string q)
        {
            Query = q;
            webGoogle.Navigate($"https://www.google.com/search?q={q}");
        }

        //First way
        public void Search()
        {
            webGoogle.Navigate($"https://www.google.com/search?q={Query}");
        }


    }
}
