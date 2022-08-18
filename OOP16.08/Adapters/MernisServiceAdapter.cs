using MernisServiceReference;
using OOP16._08.Abstract;
using OOP16._08.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP16._08.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();

            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
                customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
        }
    }
}
