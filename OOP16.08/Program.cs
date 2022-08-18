using OOP16._08.Abstract;
using OOP16._08.Adapters;
using OOP16._08.Concrete;
using OOP16._08.Entities;
using System;

namespace OOP16._08
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1998, 2, 17), FirstName = "Taha", LastName = "Kaplan", NationalityId = "21179616946" });

            Console.ReadLine();


        }
    }
}
