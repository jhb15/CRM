using System;

namespace CRM.Models
{
    public class Customer
    {
        private int Id { set; get; }
        private string Forename { set; get; }
        private string Surname { set; get; }
        private DateTime DateOfBirth { set; get; }
    }
}