using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108" };

            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(customer1);

            BaseCustomerManager customerManager1 = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager1.Save(customer1);
        }
    }
}
