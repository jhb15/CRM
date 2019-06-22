using System;

namespace CRM.Models
{
    public class Customer
    {
        public int Id { set; get; }
        public string Forename { set; get; }
        public string Surname { set; get; }
        public DateTime DateOfBirth { set; get; }
    }
}