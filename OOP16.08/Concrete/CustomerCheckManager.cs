using OOP16._08.Abstract;
using OOP16._08.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP16._08.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
