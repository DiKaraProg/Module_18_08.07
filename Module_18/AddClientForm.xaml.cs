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
using System.Windows.Shapes;

namespace Module_18
{
    /// <summary>
    /// Логика взаимодействия для AddClientForm.xaml
    /// </summary>
    public partial class AddClientForm : Window
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            if (FirstName_add.Text == String.Empty || MiddleName_add.Text == String.Empty ||
                FatherName_add.Text == String.Empty || PhoneNumber_add.Text == String.Empty ||
                Email_add.Text == String.Empty)
            {

                        MessageBox.Show("Все поля должны быть заполнены", "Внимание");
                this.Close();
                return;

            }

            
            Repository.AddNewClient(FirstName_add.Text, MiddleName_add.Text, 
                FatherName_add.Text, PhoneNumber_add.Text, Email_add.Text);
            this.DialogResult = true;
            this.Close();

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
