using System.Linq.Expressions;
using System.Xml.Linq;

namespace InheritancePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // *****  Svar på frågorna  *****
            // 3.3 13F Ett nytt attribut för samtliga fåglar ska ligga i Bird-klassen

            // 3.3 14F Ett nytt attribut för samtliga djur ska ligga i Animal-klassen

            // 3.4 9F Det funkar inte att lägga till en häst i hundlistan eftersom hästen varken är
            // eller ärver av klassen hund. 

            // 3.4 10F Listan måste vara av minsta gemensamma nämnare, i det här fallet skulle det
            // ha varit Animal.

            // 3.4 13F Funktionen Stats() körs från den klass objektet tillhör (tex Bird). I
            // funktionen körs först Stats() från klassen som ärvts (Animal) som returnerar en
            // sträng med de properties som finns på föräldraklassen, i den aktuella Stats()-
            // funktionen (Birds) läggs sen de properties som finns på den nivån till i strängen
            // innan den returneras.
            // För klasserna som ärver Bird (tex Flamingo) görs samma sak fast i ytterligare ett
            // steg, dvs tre strängar med properties slås ihop för att visa samtliga properties
            // för ett Flamingo-objekt.
            // Undantaget är Wolfman, som inte har några egna properties, och därmed ingen egem
            // Stats()-funktion, då körs funktionen som ligger på föräldern Wolf (som i sin tur
            // kör Stats() från Animal, enligt ovanstående princip.

            // 3.4 17F Den Dog-specifika funktionen går inte att nå eftersom den inte är en del
            // av Animal. För att nå den måste Dog-castas till Dog i loopen. Se stats-loopen.
            // Cast också används för att göra if-satsen för att skriva ut enbart hundar, så där
            // den hundspecifika funktionen ligger även där.



            // Test outputs for pt 1-2
            Console.WriteLine("OUTPUT FOR PART 1-2\n");

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

            foreach (var userError in userErrors)
            {
                Console.WriteLine(userError.UEMessage());
            }


            // Test outputs for pt 3

            Console.WriteLine("\n\nOUTPUT FOR PART 3-4\n");

            List<Animal> listOfAnimals = new List<Animal> // Jag vet att det stod att listan skulle heta Animals, men det kändes för otydligt i koden
            {
                new Hedgehog { Name = "Spikey", Age = 5, Color = "Brown", Habitat = "Grass", Weight = 0.512, NumberOfSpikes = 4589 },
                new Worm { Name = "Maisy", Age = 1, Color = "Beige", Habitat = "Soil", Weight = 0.010, length = 10 },
                new Horse { Name = "Jolly Jumper", Age = 12, Color = "White", Habitat = "Paddoc", Weight = 521, tailColor = "Black" },
                new Dog { Name = "Ratata", Age = 12, Color = "Brown", Habitat = "Domestic", Weight = 9.24, Pattern = "Spotted"},
                new Bird { Name = "Peep", Age = 3, Color = "Blue", Habitat = "Sky", Weight = 0.98, WingSpan = 18 },
                new Wolf { Name = "Big Bad", Age = 7, Color = "Gray", Habitat = "Forrest", Weight = 45, flockSize = 3 },
                new Flamingo { Name = "Fanny", Age = 5, Color = "Pink", Habitat = "Beach", Weight = 3.2, WingSpan = 95, ShadeOfPink = "Light" },
                new Swan { Name = "Miss Long Neck", Age = 2, Color = "White", Habitat = "Water", Weight = 8.6, WingSpan = 232, NeckLength = 50 },
                new Wolfman { Name = "Mike", Age = 35, Color = "Gray", Habitat = "The City", Weight = 72, flockSize = 1 },
                new Pelican { Name = "Pinky", Age = 4, Color = "White", Habitat = "Sky", Weight = 5.8, WingSpan = 251, BeakLength = 35 },
                new Dog { Name = "Pluto", Age = 6, Color = "Brown", Habitat = "Domestic", Weight = 8.45, Pattern = "Spotted"}
            };


            Console.WriteLine("\n-- All the animals in the list --");
            foreach (var animal in listOfAnimals)
            {
                Console.WriteLine(animal.GetType().Name);
                if (animal is IPerson castedToWolfman)
                {
                    castedToWolfman.Talk();
                }
                else
                {
                    animal.DoSound();
                }
                Console.WriteLine(); // Some space between each animal
            }

            List<Dog> listOfDogs = new List<Dog>
            {
                new Dog { Name = "Pluto", Age = 6, Color = "Brown", Habitat = "Domestic", Weight = 8.45, Pattern = "Spotted"},
//                new Horse { Name = "Jolly Jumper", Age = 12, Color = "White", Habitat = "Paddoc", Weight = 521, tailColor = "Black" },
                new Dog { Name = "Ratata", Age = 12, Color = "Brown", Habitat = "Domestic", Weight = 9.24, Pattern = "Spotted"}
            };

            Console.WriteLine("\n-- All the stats for all the animals in the list --");
            foreach (Animal animal in listOfAnimals)
            {
                // Console.WriteLine(animal.GetType().Name); // A heading to make sure each stat is correct
                Console.WriteLine(animal.Stats());
                if (animal is Dog castedToDog) // If this is a dog, run a dog specific funtion to get a pet name written out at the end of the stats-list.
                {
                    Console.WriteLine(castedToDog.PetName());
                }
                Console.WriteLine(); // Some space between each animal
            }

            Console.WriteLine("-- Stats for dogs only --"); // A heading to make sense of the stats
            foreach (Animal animal in listOfAnimals)
            {
                if (animal is Dog castedToDog)
                {
                    Console.WriteLine(castedToDog.Stats());
                    Console.WriteLine(castedToDog.PetName());
                    Console.WriteLine(); // Some space between each animal
                }
            }



            // Give time to read results, should be the last line in Main()
            Console.ReadLine();
        }
    }
}
