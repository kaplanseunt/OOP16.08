using OOP16._08.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP16._08.Entities
{
        public class Customer: IEntity     //veritabanı nesnesi oldugunu gostermek icin
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
