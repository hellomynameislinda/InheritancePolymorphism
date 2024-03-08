using System.Linq.Expressions;
using System.Xml.Linq;

namespace InheritancePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Person p = new Person();  // Test person object

            PersonHandler ph = new PersonHandler();

            Person p1 = ph.CreatePerson(26, "Anna", "Andersson", 160, 50.2);
            Person p2 = ph.CreatePerson(55, "Björn", "Berg", 180, 72.5);
            Person p3 = ph.CreatePerson(32, "Carl", "Carlson", 177, 50.2);
            Person p4 = ph.CreatePerson(46, "Dorotea", "Danielsson", 172, 77.8);

            try
            {

                // Property tests for Person objects
                ////                p.FName = null; // Null test to force error
                //                p.FName = "Testen";
                ////                p.LName = null; // Null test to force error
                //                p.LName = "Testare";
                //                p.Age = 1;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            // Test to make sure things work as they should
            //            Console.WriteLine($"{p.FName} {p.LName} is {p.Age} years old");
            Console.WriteLine($"{p1.FName} {p1.LName} is {p1.Age} years old. They weigh {p1.Weight} kilos and are {p1.Height} cm tall.");
            Console.WriteLine($"{p2.FName} {p2.LName} is {p2.Age} years old. They weigh {p2.Weight} kilos and are {p2.Height} cm tall.");
            Console.WriteLine($"{p3.FName} {p3.LName} is {p3.Age} years old. They weigh {p3.Weight} kilos and are {p3.Height} cm tall.");
            Console.WriteLine($"{p4.FName} {p4.LName} is {p4.Age} years old. They weigh {p4.Weight} kilos and are {p4.Height} cm tall.");

            Console.WriteLine();   // A bit of extra space for clearity


            var userErrors = new List<UserError>
            {
                new NumericInputError(),
                new PhoneNumberInputError(),
                new DateInputError(),
                new NumericInputError(),
                new TextInputError(),
                new DateInputError(),
                new AgeInputError(),
                new TextInputError(),
                new NumericInputError()
            };

            foreach ( var userError in userErrors )
            {
                Console.WriteLine(userError.UEMessage());
            }






            // Give time to read results, should be the last line in Main()
            Console.ReadLine();
        }
    }
}
