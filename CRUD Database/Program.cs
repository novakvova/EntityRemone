using FluentValidation.Results;
using System;
using System.Linq;

namespace CRUD_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var user = new AppUser();
            Console.WriteLine("Вкажіть прізвище: ");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Вкажіть ім'я: ");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Вкажіть пошту: ");
            user.Email = Console.ReadLine();
            Console.WriteLine("Вкажіть телефон: ");
            user.Phone = Console.ReadLine();

            AppUserValidator validator = new AppUserValidator();

            ValidationResult results = validator.Validate(user);
            if (results.IsValid)
            {

                MyEFContext context = new MyEFContext();
                context.Users.Add(user);
                context.SaveChanges();
            }
            else
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }

            //using (MyEFContext context = new MyEFContext())
            //{
            //    foreach (var user in context.Users.OrderBy(x=>x.Id))
            //    {
            //        Console.WriteLine(user);
            //    }
            //    //context.Dispose();
            //    //context = null;

            //    Console.WriteLine("Якого користувача змінити?");
            //    int id = int.Parse(Console.ReadLine());
            //    var userEdit = context.Users.SingleOrDefault(x=>x.Id==id);
            //    if(userEdit is not null) //userEdit!=null
            //    {
            //        userEdit.LastName = "--------";
            //        context.SaveChanges();
            //    }
            //}



        }
    }
}
