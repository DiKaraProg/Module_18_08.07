using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    public class Repository
    {

        
        public static List<Client> ReturnAllClients()
        {
            
            var list = new List<Client>();
            var ClientDb = MainWindow.context.Clients;
            foreach (Client client in ClientDb)
            {
                list.Add(client);
            }
            return list;
        }
        public static List<Order> ReturnAllOrders()
        {
            
            var list = new List<Order>();
            var OrdersDb = MainWindow.context.Orders;
            foreach (Order item in OrdersDb)
            {
                list.Add(item);
            }
            return list;
        }
        public static void AddNewClient(string FirstName,string MiddleName,string FatherName,string PhoneNumber,string Email)
        {
            Client client = new Client(FirstName, MiddleName, FatherName, PhoneNumber, Email);
            MainWindow.context.Clients.Add(client);
            MainWindow.context.SaveChanges();
        }
        public static void AddNewOrder(string Email, int ProductId, string ProductName)
        {
            Order order = new Order(Email,ProductId,ProductName);
            MainWindow.context.Orders.Add(order);
            MainWindow.context.SaveChanges();
        }
        public static void DeleteClient(Client client)
        {
           
            var clients=  MainWindow.context.Clients;
            foreach (Client item in clients)
            {
                if (item.ClientId == client.ClientId)
                {
                    MainWindow.context.Clients.Remove(item);break;
                }
            }
            MainWindow.context.SaveChanges();
        }
        public static void DeleteOrder(Order order)
        {
            var orders = MainWindow.context.Orders;
            foreach (Order item in orders)
            {
                if (item.OrderId == order.OrderId)
                {
                    MainWindow.context.Orders.Remove(item);break;
                }
            }
            MainWindow.context.SaveChanges();
        }
        public static List<Templete> CreateTemplateTable()
        {
            var templates = new List<Templete>();
            var orders = MainWindow.context.Orders;
            var clients = MainWindow.context.Clients;
            int id = 1;

            foreach (Client item in clients)
            {
                foreach (Order item1 in orders)
                {
                    if (item1.Email == item.Email)
                    {
                        
                        templates.Add(new Templete(id,item.Email, item.FirstName, item1.ProductId, item1.ProductName));
                        id++;
                    }
                }
            }
            return templates;
         }
        public static void Edit()
        {
           

        }
    }
}
