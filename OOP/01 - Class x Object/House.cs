namespace OOP
{
    //Class definition
    public class House
    {
        public int SizeSquareMeters { get; set; }
        public int Floors { get; set; }
        public decimal Value { get; set; }
        public int VacanciesNumber { get; set; }
    }

    //Object definition
    public class Object
    {
        public Object()
        {
            House house = new House
            {
                SizeSquareMeters = 100,
                Floors = 2,
                Value = 100000,
                VacanciesNumber = 3
            };
        }
    }
}
