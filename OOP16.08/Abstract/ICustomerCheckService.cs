using OOP16._08.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP16._08.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
