using Abstraction.Interfaces.Models;
using Domain;
using Domain.Service;

namespace UI_Console
{
    internal class Program
    {
        static ICustomer customer = new Domain.Models.Customer();

        static void Main(string[] args)
        {

            CustomerService domain = new CustomerService();

            customer.Name = RequestCustomerName();

            Console.Clear();
            customer.Id = RequestCustomerID();

            Console.Clear();
            Console.WriteLine(domain.SaveCustomer(customer));
        }

        static int RequestCustomerID()
        {
            Console.WriteLine("Type a id for the User");

            string? input = Console.ReadLine();

            while ((int.TryParse(input, out int id) == false) || String.IsNullOrEmpty(input))
            {
                Console.WriteLine($"{id} is not a valid input! Try again");

                input = Console.ReadLine();
            }

            Console.Clear();

            return int.Parse(input);
        }

        static string RequestCustomerName()
        {
            Console.WriteLine("Type the customers full name");

            string input = Console.ReadLine();

            while (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input! Try again");
                
                input = Console.ReadLine();
            }

            Console.Clear();

            return input;
        }
    }
}