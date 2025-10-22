using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppLibraryManager.Application.Utils
{
    public static class FieldEmptyValidation
    {
        public static string FieldValidation(string fieldName, string entityName)
        {
            string optionSelected = string.Empty;
            string fieldValue = string.Empty;

            while (string.IsNullOrEmpty(fieldValue)){

                Console.WriteLine($"{fieldName} cannot be null or empty.");
                Console.WriteLine($"Please, enter the {entityName} {fieldName}:");
                fieldValue = Console.ReadLine()!;

                Console.WriteLine($"{fieldName} cannot be null or empty.");
                Console.WriteLine("Do you want to continue the operation?");
                Thread.Sleep(1000);
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                optionSelected = Console.ReadLine()!;

                if (optionSelected == "2")
                {
                    Console.WriteLine("Operation cancelled.");
                    return string.Empty;
                }
            }

            return fieldValue;
        }
    }
}
