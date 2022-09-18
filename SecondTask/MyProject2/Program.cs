using System;

namespace CurrencyConverter
{
    class Converter
    {
        public double usd = 36.43;
        public double eur = 36.88;
        public double rub = 0.61;
    }
    class Project
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Converter CourseValue = new Converter();
            string FirstCurrency;
            string SecondCurrency;
            string CurrencyAmount;
            double CurrencyAmount2;
            double Result = 0;
            Console.WriteLine("Яку валюту ви хочете обміняти? usd/eur/rub/uan");
            FirstCurrency = Console.ReadLine();
            if (FirstCurrency != "usd" && FirstCurrency != "eur" && FirstCurrency != "rub" && FirstCurrency != "uan")
            {
                Console.WriteLine("Помилка. Неправильний вибір валюти.");
                return;
            }
            Console.WriteLine("Скільки валют ви хочете обміняти?");
            CurrencyAmount = Console.ReadLine();
            CurrencyAmount2 = Convert.ToDouble(CurrencyAmount);
            if (CurrencyAmount2 < 0)
            {
                Console.WriteLine("Число повинно бути більше нуля!");
                return;
            }
            if (FirstCurrency == "usd")
            {
                Result = CurrencyAmount2 * CourseValue.usd;
                Result = Math.Round(Result, 2);
                Console.WriteLine(CurrencyAmount2 + " USD = " + Result + " UAN");
                Console.ReadKey();
            }
            if (FirstCurrency == "eur")
            {
                Result = CurrencyAmount2 * CourseValue.eur;
                Result = Math.Round(Result, 2);
                Console.WriteLine(CurrencyAmount2 + " EUR = " + Result + " UAN");
                Console.ReadKey();
            }
            if (FirstCurrency == "rub")
            {
                Result = CurrencyAmount2 * CourseValue.rub;
                Result = Math.Round(Result, 2);
                Console.WriteLine(CurrencyAmount2 + " RUB = " + Result + " UAN");
                Console.ReadKey();
            }
            if (FirstCurrency == "uan")
            {
                Console.WriteLine("Яку валюту ви хочете обміняти? usd/eur/rub");
                SecondCurrency = Console.ReadLine();

                if (SecondCurrency == "usd")
                {
                    Result = CurrencyAmount2 / CourseValue.usd;
                    Result = Math.Round(Result, 2);
                    Console.WriteLine(CurrencyAmount2 + " UAN = " + Result + " USD");
                    Console.ReadKey();
                }
                if (SecondCurrency == "eur")
                {
                    Result = CurrencyAmount2 / CourseValue.eur;
                    Result = Math.Round(Result, 2);
                    Console.WriteLine(CurrencyAmount2 + " UAN = " + Result + " EUR");
                    Console.ReadKey();
                }
                if (SecondCurrency == "rub")
                {
                    Result = CurrencyAmount2 / CourseValue.rub;
                    Result = Math.Round(Result, 2);
                    Console.WriteLine(CurrencyAmount2 + " UAN = " + Result + " RUB");
                    Console.ReadKey();
                }
            }
        }
    }
}