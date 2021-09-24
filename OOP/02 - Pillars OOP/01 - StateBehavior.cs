using System;

namespace OOP
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int CalculateAge()
        {
            DateTime actualDate = DateTime.Now;
            int age = actualDate.Year - BirthDate.Year;

            if (actualDate < BirthDate.AddYears(age)) age--;

            return age;
        }
    }
}
