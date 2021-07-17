using Bogus;
using CoffeeLib;
using System;

namespace Delegate
{
    delegate void MyDelegate();
    class Program
    {
        
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = showInfo;
            //myDelegate();
            //showInfo();
            //Console.WriteLine("Hello World!");

            //CoffeeService coffeeService = new CoffeeService();
            //coffeeService.completedCoffee = myShowInfoCoffee;
            //coffeeService.RunExpresso();
            
            //Animal cat = new Animal();
            //cat.Name = "Мурка";

            var faker = new Faker<Animal>("uk")
                .RuleFor(x=>x.Name, f=>f.Name.FirstName());
            for (int i = 0; i < 10; i++)
            {
                var cat = faker.Generate();
                Console.WriteLine(cat.Name);
            }
            

        }

        static void myShowInfoCoffee(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        static void showInfo()
        {
            Console.WriteLine("Hello delegate");
            
        }


    }
}
