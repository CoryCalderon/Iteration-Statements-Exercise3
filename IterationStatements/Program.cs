namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Main(string[] args) 
        {
            //PrintNums1000();

            //PrintNums3();

            //EqualParameters();

            //EvenOrOdd(6);

            //PosOrNeg(3);

            //CanVote();

            //InRange(20);

            //Multiply(2);
        }
        
        public static void PrintNums1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintNums3()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualParameters(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are the same!");
            }
            else
            {
                 Console.WriteLine($"{num1} and {num2} aren't the same!");
            }

        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num3)
        {
            if(num3 % 2 == 0) 
            {
                Console.WriteLine($"{num3} is even");
            }
            else
            {
                Console.WriteLine($"{num3} is odd!");
            }

        }
        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int num4)
        { 
            if (num4 > 0)
            {
                Console.WriteLine($"{num4} is Positive!");
            }
            else
            {
                Console.WriteLine($"{num4} isn't Positive!");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote()
        {
            Console.WriteLine("Please enter your age:");
            bool canParse = int.TryParse(Console.ReadLine(), out int userAge);

            while(canParse == false)
            {
                Console.WriteLine("Invalid input. Please enter your age:");
                canParse = int.TryParse(Console.ReadLine(),out userAge);
            }
            Console.WriteLine($"You entered {userAge} for your age.");

            if(userAge > 18)
            {
                Console.WriteLine($"Congrats! You're old enough to vote!");
            }
            else
            {
                Console.WriteLine($"You are not of age to vote.");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange(int userGuess)
        {
            
            Console.WriteLine($"Lets see if your integer is in range.");

            if (userGuess <= 10 && userGuess >= -10)
            {
                Console.WriteLine($"Your selection, {userGuess}, is in range.");
            }
            else
            {
                Console.WriteLine($"Your selection, {userGuess}, is not range!");
            }



        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Multiply(int num6)
        {
            
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num6} = {i * num6}");
            }

        }

        
               
        
    }
}
