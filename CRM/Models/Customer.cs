using System;

namespace CRM.Models
{
    public class Customer
    {
        public int CustomerId { set; get; }
        public string Forename { set; get; }
        public string Surname { set; get; }
        public DateTime DateOfBirth { set; get; }

        public int GetAge()
        {
            var now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            var dob = int.Parse(DateOfBirth.ToString("yyyyMMdd"));

            return (now - dob) / 10000;
        }
        
        public override string ToString()
        {
            return $"CustomerId: {CustomerId}" 
                                  + $", Forename: {Forename}" 
                                  + $", Surname: {Surname}" 
                                  + $", Date of Birth: {DateOfBirth:d}" 
                                  + $", Age: {GetAge()}";
        }
    }
}