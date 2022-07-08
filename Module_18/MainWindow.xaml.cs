using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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

namespace Module_18
{
    
    public partial class MainWindow : Window
    {
        private static DataRowView rowView;
        private static Order tempOrder;
        private static Client tempClient;
        public static AllTableContext context;
        public MainWindow()
        {
            context = new AllTableContext();
            InitializeComponent();
            DataGrid.DataContext= Repository.ReturnAllClients();
            DataGrid_Orders.DataContext=  Repository.ReturnAllOrders();
            
        }

       

        private void MenuItem_Click_Add_Client(object sender, RoutedEventArgs e)
        {
            AddClientForm addClient = new AddClientForm();
            addClient.ShowDialog();
            if (addClient.DialogResult.Value)
            {
                DataGrid.DataContext = Repository.ReturnAllClients();
            }
            
        }
        private void MenuItem_Click_Add_Order(object sender, RoutedEventArgs e)
        {
            AddOrderForm addOrder = new AddOrderForm();
            addOrder.ShowDialog();
            if (addOrder.DialogResult.Value)
            {
                DataGrid_Orders.DataContext = Repository.ReturnAllOrders();
            }
        }

        private void MenuItem_Click_Delete_Client(object sender, RoutedEventArgs e)
        {
           var client = (Client)DataGrid.SelectedItem;
            Repository.DeleteClient(client);
            DataGrid.DataContext = Repository.ReturnAllClients();
        }


        private void MenuItem_Click_Delete_Order(object sender, RoutedEventArgs e)
        {
            var order = (Order)DataGrid_Orders.SelectedItem;
            Repository.DeleteOrder(order);
            DataGrid_Orders.DataContext = Repository.ReturnAllOrders();
        }
        
        

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TemplateTables template = new TemplateTables();
            template.ShowDialog();
        }

        private void SaveAll(object sender, RoutedEventArgs e)
        {
            var listorders = Repository.ReturnAllOrders();
            var listclients = Repository.ReturnAllClients();
            
            var DbOrder = context.Orders;
            var DbClient = context.Clients;
            foreach (Order item in DbOrder)
            {
                foreach (var item1 in listorders)
                {
                    if (item.OrderId == item1.OrderId)
                    {
                        item.ProductId = item1.ProductId;
                        item.ProductName = item1.ProductName;
                        item.Email = item1.Email;
                        
                    }
                }
                
            }
            context.Orders = DbOrder;

            foreach (Client item in DbClient)
            {
                foreach (var item1 in listclients)
                {
                    if (item.ClientId == item1.ClientId)
                    {
                        item.MiddleName = item1.MiddleName;
                        item.PhoneNumber = item1.PhoneNumber;
                        item.Email = item1.Email;
                        item.FirstName = item1.FirstName;
                        item.FatherName = item1.FatherName;

                    }
                }
            }
            context.SaveChanges();
            MessageBox.Show("Saved successfully");
           
            
        }
    }
}
