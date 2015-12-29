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

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //PROPERTIES
        List<Student> Students = new List<Student>();
        int Index = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            //ad student to the list 
            Students.Add(new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text));
            MessageBox.Show("Student Created ");
            Index = Students.Count;
            //Clearing TextBoxs
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (Index == Students.Count)
            {
                Index = 0;
            }
            else
            {
                Index++;
            }

           
            //Display next element
            txtFirstName.Text = Students[Index].FirstName;
            txtLastName.Text = Students[Index].LastName;
            txtCity.Text = Students[Index].City;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (Index == 0)
            {
                Index = Students.Count;
            }
            else
            {
                Index--;
            }
            //Display previous element
            txtFirstName.Text = Students[Index].FirstName;
            txtLastName.Text = Students[Index].LastName;
            txtCity.Text = Students[Index].City
        }
    }
}
