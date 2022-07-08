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
    /// Логика взаимодействия для AddOrderForm.xaml
    /// </summary>
    public partial class AddOrderForm : Window
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }
        private void AddButton1_Click(object sender, RoutedEventArgs e)
        {
            if (Email_add.Text == String.Empty || Product_Id_add.Text == String.Empty ||
               Product_Name_add.Text == String.Empty )
            {

                MessageBox.Show("Все поля должны быть заполнены", "Внимание");
                this.Close();
                return;

            }


            Repository.AddNewOrder(Email_add.Text,Convert.ToInt32(Product_Id_add.Text),Product_Name_add.Text);
            this.DialogResult = true;
            this.Close();
        }

        private void CloseButton1_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

    }
}
