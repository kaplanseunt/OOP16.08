using OOP16._08.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP16._08.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db " + customer.FirstName);
        }
    }
}
