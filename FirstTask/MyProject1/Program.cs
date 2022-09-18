using System;

namespace MyProject1
{

    class Address
    {
        public string index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string house { get; set; }
        public string apartment { get; set; }

    }
    class Project
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Address directions = new Address();
            directions.index = "04070";
            directions.country = "Україна";
            directions.city = "Київ";
            directions.street = "Андріївський узвіз";
            directions.house = "8";
            directions.apartment = "17";
            Console.WriteLine(directions.index + ", " + directions.country + ", " + directions.city + ", " + directions.street + ", " + directions.house + ", " + directions.apartment);
            Console.ReadKey();
        }
    }
}
