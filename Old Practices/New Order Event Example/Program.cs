using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Order_Event_Example
{

    public class OrdersItemsArg : EventArgs
    {
        public int OrderID { get; set; }
        public string OrderName { get; set; }

        public string CustomerEmail { get; set; }

        public OrdersItemsArg(int OrderID, string OrderName, string Email)
        {
            this.OrderID = OrderID;
            this.CustomerEmail = OrderName;
            this.OrderName = Email;
        }

    }


    public class Orders
    {
        public event EventHandler<OrdersItemsArg> OnOrderChanged;

        public void CreateOrder(int OrderID,string OrderName,string Email)
        {
            Console.WriteLine("Order has Created Successfully. Now We Will Notify All The Subscribers.");

            if(OnOrderChanged != null)
            {
                OnOrderChanged(this, new OrdersItemsArg(OrderID, OrderName, Email));
            }
        }
    }

    public class EmailServices
    {
        public void Subscribe(Orders Order)
        {
            Order.OnOrderChanged += Order_OnOrderChanged;
        }

        public void UnSubscribe(Orders Order)
        {
            Order.OnOrderChanged -= Order_OnOrderChanged;
        }

        private void Order_OnOrderChanged(object sender, OrdersItemsArg e)
        {

            Console.WriteLine("\t\t Email Service");
            Console.WriteLine("\t\t Info :");
            Console.WriteLine("\t\t -------------------------------------");
            Console.WriteLine($"\t\t Order ID  : {e.OrderID}");
            Console.WriteLine($"\t\t Order ID  : {e.OrderName}");
            Console.WriteLine($"\t\t Order ID  : {e.CustomerEmail}");
            Console.WriteLine("\t\t -------------------------------------");
        }
    }

    public class SMS_Services
    {
        public void Subscribe(Orders Order)
        {
            Order.OnOrderChanged += Order_OnOrderChanged;
        }

        public void UnSubscribe(Orders Order)
        {
            Order.OnOrderChanged -= Order_OnOrderChanged;
        }

        private void Order_OnOrderChanged(object sender, OrdersItemsArg e)
        {

            Console.WriteLine("\t\t SMS Service");
            Console.WriteLine("\t\t Info :");
            Console.WriteLine("\t\t -------------------------------------");
            Console.WriteLine($"\t\t Order ID  : {e.OrderID}");
            Console.WriteLine($"\t\t Order ID  : {e.OrderName}");
            Console.WriteLine($"\t\t Order ID  : {e.CustomerEmail}");
            Console.WriteLine("\t\t -------------------------------------");
        }
    }

    public class ShippersServices
    {
        public void Subscribe(Orders Order)
        {
            Order.OnOrderChanged += Order_OnOrderChanged;
        }

        public void UnSubscribe(Orders Order)
        {
            Order.OnOrderChanged -= Order_OnOrderChanged;
        }

        private void Order_OnOrderChanged(object sender, OrdersItemsArg e)
        {

            Console.WriteLine("\t\t Shippers Service");
            Console.WriteLine("\t\t Info :");
            Console.WriteLine("\t\t -------------------------------------");
            Console.WriteLine($"\t\t Order ID  : {e.OrderID}");
            Console.WriteLine($"\t\t Order ID  : {e.OrderName}");
            Console.WriteLine($"\t\t Order ID  : {e.CustomerEmail}");
            Console.WriteLine("\t\t -------------------------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var Order = new Orders();

            var Email = new EmailServices();

            var SMS = new SMS_Services();

            var Shipper = new ShippersServices();

            Email.Subscribe(Order);

            SMS.Subscribe(Order);

            Shipper.Subscribe(Order);

            Order.CreateOrder(22, "My Prime", "ZakaStreet@gmail.com");

            Console.ReadKey();
        }
    }
}
