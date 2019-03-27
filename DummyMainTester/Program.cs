using Custs.Model;
using Custs.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyMainTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.Name = "HT";
            Order order = new Order();
            order.Name = "Unified 10";
            Order order2 = new Order();
            order2.Name = "EU REG";

            cust.Orders = new List<IOrder>
            {
                (IOrder)order,
                (IOrder)order2
            };

            pl("Customer : " + cust.Name);
            for (int i = 0; i < cust.Orders.Count; i++)
            {
                pl("\tCustomer order: " + cust.Orders.ElementAt(i).Name);
            }
        }

        private static void pl(string name)
        {
            Console.WriteLine(name);
        }
    }
}
