using System;

namespace OOP
{
    public class Employee : Person
    {
        public DateTime AdmissionDate { get; set; }
        public string Register { get; set; }
    }

    public class Process
    {
        public void Execution()
        {
            Employee employee = new Employee()
            {
                Name = "João da Silva",
                BirthDate = Convert.ToDateTime("1990/01/01"),
                AdmissionDate = DateTime.Now,
                Register = "0123456",
            };

            employee.CalculateAge();
        }
    }
}