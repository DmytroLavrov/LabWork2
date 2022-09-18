using System;

namespace MyProject4
{
    class User
    {
        public string login, name, lastname;
        int age;
        public readonly DateTime date;
        public string Login        
        {
            set { login = value; } get
            {
                if (login == null)
                return "Помилка. Поле не заповнено. Спробуйте ще раз!";
                return login;
            }
        }
        public string Name
        {
            set { name = value; } get
            {
                if (name == null)
                return "Помилка. Поле не заповнено. Спробуйте ще раз!";
                return name;
            }
        }
        public string LastName
        {
            set { lastname = value; } get
            {
                if (lastname == null)
                return "Помилка. Поле не заповнено. Спробуйте ще раз!";
                return lastname;
            }
        }
        public int Age
        {
            set { age = value; } get
            {
                if (age <= 0)
                return 25;
                return age;
            }
        }
        public User()
        {
            date = DateTime.Now;    //Дата
        }
        public User(string login, string name, string lastname, int age)
        {
            this.Login = login;
            this.Name = name;
            this.LastName = lastname;
            this.Age = age;
            date = DateTime.Now;
        }
    }
    class Project
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            User nickname = new User();
            nickname.Login = "Лавров";
            nickname.Name = "Дмитро";
            nickname.LastName = "Анатолійович";
            nickname.Age = 18;
            Console.WriteLine("Персональні дані користувача: " + nickname.Login + ", " + nickname.Name + ", " + nickname.LastName + ", " + nickname.Age + ", " + DateTime.Now);
            Console.ReadLine();
        }
    }
}
