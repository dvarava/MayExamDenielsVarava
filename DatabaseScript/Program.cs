using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MayExamDenielsVarava;
using System.Data.Entity;

namespace DatabaseScript
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var context = new RestaurantData())
                {
                    // Create customer objects
                    Customer c1 = new Customer() { Name = "Tom Jones", ContactNumber = "086-123 4567" };
                    Customer c2 = new Customer() { Name = "Mary Smith", ContactNumber = "086 546 3214" };
                    Customer c3 = new Customer() { Name = "Jo Doyle", ContactNumber = "087 1221 222" };

                    // Add customers to Customers table in the db
                    context.Customers.Add(c1);
                    context.Customers.Add(c2);
                    context.Customers.Add(c3);

                    // Save db
                    context.SaveChanges();
                }

                Console.WriteLine("Database created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
