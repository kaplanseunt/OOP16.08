using OOP16._08.Abstract;
using OOP16._08.Adapters;
using OOP16._08.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP16._08.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private  ICustomerCheckService _customerCheckService;
            
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {

                base.Save(customer);

            }
            else
            {
                throw new Exception("not a valid person");
            }
        }

    }
}
