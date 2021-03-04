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

namespace Classes3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StudentInfo : Window
    {
        public Student SelectedStudent { get; set; }
        public StudentInfo()
        {
            InitializeComponent();
        }

        public void PopulateWithStudentInfo(Student moreInfo)
        {
            txtFirstName.Text = moreInfo.FirstName;
            txtLastName.Text = moreInfo.LastName;
            txtMajor.Text = moreInfo.Major;
            txtState.Text = moreInfo.Address.State;
            txtStreetName.Text = moreInfo.Address.StreetName;
            txtStreetNumber.Text = moreInfo.Address.StreetNumber.ToString();

            txtFirstName.IsEnabled = false;
            txtLastName.IsEnabled = false;
            txtMajor.IsEnabled = false;
            txtState.IsEnabled = false;
            txtStreetName.IsEnabled = false;
            txtStreetNumber.IsEnabled = false;
        }

    }
}
