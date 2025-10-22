using ConsoleAppLibraryManager.Application.Utils;
using ConsoleAppLibraryManager.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLibraryManager.Application.UserServices
{
    internal class UserService
    {
        User? CreateUser(User model)
        {
            string name;
            string email;
            string optionSelected;
            int tries;

            Console.WriteLine("Please, enter the customer name:");
            name = Console.ReadLine()!;

            if (string.IsNullOrEmpty(name))
            {

                name = FieldEmptyValidation.FieldValidation("Name", "user");
            }

            Console.WriteLine("Please, enter the customer email:");
            email = Console.ReadLine()!;

            while (string.IsNullOrEmpty(email))
            {
                email = FieldEmptyValidation.FieldValidation("Email", "user");
            }

            return new User(name, email);
        }
    }
}
