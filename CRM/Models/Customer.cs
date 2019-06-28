using System;

namespace CRM.Models
{
    public class Customer
    {
        public int CustomerId { set; get; }
        public string Forename { set; get; }
        public string Surname { set; get; }
        public DateTime DateOfBirth { set; get; }

        public override string ToString()
        {
            return CustomerId + "," + Forename + "," + Surname + "," + DateOfBirth;
        }
    }
}