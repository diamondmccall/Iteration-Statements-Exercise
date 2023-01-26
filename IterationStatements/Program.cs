namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below

        static void Main(string[] args)

        {
            MultiplicationTable();
            Threes();
            IsEqual(8, 11);
            IsEvenOrOdd();
            IsPositive();
            OldEnough();
            InRange();

        }

        public static void MultiplicationTable()

        {
            int numbers, multiplier;
            Console.WriteLine("Enter a number");
            numbers = Convert.ToInt32(Console.ReadLine());

            for ( multiplier = 1; multiplier <= 10; multiplier++)
            {
                Console.WriteLine("{0} * {1} = {2}", numbers, multiplier, (numbers * multiplier));
                    
            }
        }   


        public static void InRange()

        {
            Console.WriteLine("Choose any number betwwen -10 and 10");
            int userNumber = int.Parse(Console.ReadLine());
            

            if (userNumber >= -10 && userNumber <= 10)

            {
                Console.WriteLine("Nice Job!");
            }
            else
            {
                Console.WriteLine("Try again.");
            }

        }   

        public static void OldEnough()

        {
            var userAge = 30;
            Console.WriteLine("how old are you?");
            userAge = int.Parse(Console.ReadLine());

            if (userAge >= 18)
            {
                Console.WriteLine("Thank you for voting!");
            }
            else
            {
                Console.WriteLine("Sorry, you must be 18 or older to vote.");
            }

        }


        public static void IsPositive()
        {
            int c;
            Console.WriteLine("type any number");
            c = int.Parse(Console.ReadLine());

            if (c >= 0)
            {
                Console.WriteLine("that's a positive number!");

             }
            else
            {
                Console.WriteLine("that's a negative number!");
            }

        }

       


        public static void IsEvenOrOdd()

        {
            int number;
            Console.WriteLine("enter a number");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)

            {
                Console.WriteLine("is even!");
            }
            else
            {
                Console.WriteLine("odd!");
            }
        }

        public static bool IsEqual(int a, int b)

        {

            if (a == b)

            {
                return true;

            }
            else
            {
                return false;
            }

                       

        }

         public static void Threes()
        {
            for (int e = 3; e <= 999; e += 3)
            {
                Console.WriteLine(e);
            }


        }


         public static void PrintThousand()

        {
            for (int i = 1000; i >= -1000; i--)

            {
               Console.WriteLine(i);
            }

        


        }
    }
}
