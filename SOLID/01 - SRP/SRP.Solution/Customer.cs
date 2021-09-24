using System;

namespace SOLID.SRP.Solution
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Email Email { get; set; }
        public Cpf Cpf { get; set; }
        public DateTime RegistrationDate { get; set; }

        public bool Validate()
        {
            return Email.Validate() && Cpf.Validate();
        }
    }
}