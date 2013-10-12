using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new IndianCustomer();
            customer.ShipOrder();
            Console.ReadKey();
        }
    }
    class Customer
    {
        public virtual void ShipOrder()
        {
            CustomerShipper customerShipper = new CustomerShipper();
            customerShipper.ShipOrder();
        }
    }
 
    class IndianCustomer : Customer
    {
        public override void ShipOrder()
        {
            CustomerShipper customerShipper = new IndianCustomerShipper();
            customerShipper.ShipOrder();
            //base.ShipOrder();
        }
    } 
 
    class CustomerOrder
    {
        public virtual void ProcessOrder()
        {
            Console.WriteLine("Process order in USD..");
        }
    }
 
    class IndianCustomerOrder : CustomerOrder
    {
        public override void ProcessOrder()
        {
            Console.WriteLine("Process order in INR..");
            //base.ProcessOrder();
        }
    } 
    class CustomerShipper
    {
        public virtual void ShipOrder()
        {
            DataAcess dataAcess = new DataAcess();
            dataAcess.GetProducts();
            CustomerOrder customerOrder = new CustomerOrder();
            customerOrder.ProcessOrder();
            Console.WriteLine("Shipping to NY via train...");
        }
    }

    class IndianCustomerShipper : CustomerShipper
    {
        public override void ShipOrder()
        {
            //base.ShipOrder();
            DataAcess dataAcess = new DataAcess();
            dataAcess.GetProducts();
            CustomerOrder customerOrder = new IndianCustomerOrder();
            customerOrder.ProcessOrder();
            Console.WriteLine("Shipping to Delhi via Flight...");
        }
    } 
    class DataAcess
    {
        public List<Product> GetProducts()
        {
            Console.WriteLine("Fetching products from db...");
            return new List<Product>();
        }
    } 
    class Product
    {
         int ProductID{get;set;}
        string ProductName {get;set;}
    }
}