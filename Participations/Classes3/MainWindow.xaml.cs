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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Major = txtMajor.Text
            };

            Address a = new Address()
            {
                StreetName = txtStreetName.Text,
                StreetNumber = Convert.ToInt32(txtStreetNumber.Text),
                State = txtState.Text
            };

            s.Address = a;
            lstStudents.Items.Add(s);

        }

        private void lstStudents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Student selected = (Student)lstStudents.SelectedItem;
            StudentInfo infoWindow = new StudentInfo();
            infoWindow.SelectedStudent = selected;
            infoWindow.PopulateWithStudentInfo(selected);
            infoWindow.ShowDialog();
        }
    }
}
