
// Program.cs is the main file that acts as the entrypoint for our program
using Newtonsoft.Json;

namespace GettingStarted
{
    class Program
    {
        static void Main()
        {

            //! 1. Variables and DataTypes
            /*
                * String Interpolation: https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation
            */
            int myNumber = 1;
            Console.WriteLine($"My Number: {myNumber} \n");

            string greeting = "Hello Wurld!";
            double pi = 3.14159;
            bool iLoveMaterDev = true;
            Console.WriteLine($"{greeting}, My favorite number is {pi}. Also it is {iLoveMaterDev} that I Love Mater Dev. \n");

            //! 2. Flow Control Structures

            // If/Else
            if (myNumber > 5)
            {
                Console.WriteLine("myNumber is greater than 5!");
            }
            else
            {
                Console.WriteLine("myNumber is less than 5!");
            }

            Console.WriteLine();

            // For
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Loop iteration: {i}");
            }

            //! 3. Arrays and Collections

            int[] myNumberArray = { 1, 2, 13, 24, 53, 61, 709, 88, 33, 9};
            foreach (int i in myNumberArray)
            {
                Console.WriteLine($"Current number from myNumberArray: {i}");
            }

            //! 4. Methods

            void DisplayMessage(string message)
            {
                Console.WriteLine($"Message: {message}");
            }

            DisplayMessage("Ay yo, pick up the phone!");

            Console.WriteLine();

            //! 5. Classes and Objects
            // Could not get declaration of a class within  class to work, so moved Mouse class to ./Mouse.cs 
            var myMouse = new Mouse { Name = "Squeekers" };
            var myOtherMouse = new Mouse { Name = "Geekers" };
            // Introduce() is a public method, which means it can be called outside of the class.

            myMouse.Introduce();
            myOtherMouse.Introduce();

            // Updating the secret code for all mice.
            Mouse.SecretCode = 10;

            myMouse.GetSecretCode();
            myOtherMouse.GetSecretCode();

            Console.WriteLine();
            Console.WriteLine($"myNumberArray: {string.Join(", ", myNumberArray)}");
            
            //! 6. Language Integrated Query (LINQ)
                // * all following examples are using myNumberARray

            // Where() - similar to JS .filter()
            // create a new array of only even numbers
            var evenNumbers = myNumberArray.Where(n => n % 2 == 0);

            // In C# we cannot directly print an array to the console, it must be stringified.
            Console.WriteLine($"Even Numbers: {string.Join(", ", evenNumbers)}");
            // We can still access the numbers at the indexes and log them
            foreach (int number in evenNumbers) {
                Console.WriteLine($"\t {number}");
            }

            // Select() - similar to JS .map()
                // Create a new array with some transformation over all the items
            var squaredNumbers = myNumberArray.Select(n => n * n);
            Console.WriteLine($"Squared Numbers: {string.Join(", ", squaredNumbers)}");
            

            // OrderBy() & OrderByDescending() - similar to JS .sort()
            var sortedNumbersASC = myNumberArray.OrderBy(n => n);
            var sortedNumbersDESC = myNumberArray.OrderByDescending(n => n);
            Console.WriteLine($"Order Numbers (ASC): {string.Join(", ", sortedNumbersASC)}");
            Console.WriteLine($"Order Numbers (DESC): {string.Join(", ", sortedNumbersDESC)}");
            

            // GroupBy()
            var GroupedBy = myNumberArray.GroupBy(n => n % 3 == 0).ToList();
            Console.WriteLine($"Group Numbers (Odd): {string.Join(", ", GroupedBy[0])}");
            Console.WriteLine($"Group Numbers (Even): {string.Join(", ", GroupedBy[1])}");

            // Aggregate() - Similar to JS .reduce()
                // Can provide a number before the callback function to be a "seed value"
            var sum = myNumberArray.Aggregate(10, (acc,  n) => acc + n);
            Console.WriteLine($"Sum of myNumberArray: {sum}");

            //! 7. Using a dependency within the code.
                // JSON serialization for an object.
                // Using myMouse as an example
            string mouseJson = JsonConvert.SerializeObject(myMouse);
            Console.WriteLine($"My Mouse Json: \n {mouseJson}");

            // Can serialize IEnumerable types, from LINQ
            string GroupedByJson = JsonConvert.SerializeObject(GroupedBy);
            Console.WriteLine($"My GroupBy Json: \n {GroupedByJson}");

        }
    }
}
