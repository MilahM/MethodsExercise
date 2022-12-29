using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 1
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string userAge = Console.ReadLine();

            Console.WriteLine("If you could be any animal what would you be?");
            string userAnimal = Console.ReadLine();

            Console.WriteLine("Who is your favorite artist?");
            string userArtist = Console.ReadLine();

            Console.WriteLine($"Your name is {userName} and you are {userAge} years old. " +
                $"You went on American Idol where {userArtist} was a judge " +
                $"and said that you sound like a {userAnimal} singing. " +
                $"Your dreams were instantly crushed.");

            //EXERCISE 2
            Console.WriteLine("Enter one number to add to another number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number to add to the first:");
            double num2 = double.Parse(Console.ReadLine());

            double sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Enter one number to subtract from another number:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number to subtract from the first:");
            num2 = double.Parse(Console.ReadLine());

            double difference = Difference(num1, num2);
            Console.WriteLine($"The difference is: {difference}");

            Console.WriteLine("Enter one number to multiply by another number:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number to multiple by the first:");
            num2 = double.Parse(Console.ReadLine());

            double product = Product(num1, num2);
            Console.WriteLine($"The product is: {product}");

            Console.WriteLine("Enter a numerator:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a denominator:");
            num2 = double.Parse(Console.ReadLine());

            double quotient = Quotient(num1, num2);
            Console.WriteLine($"The quotient is: {quotient}");


        }
        //EXERCISE 2
        public static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Difference(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Product(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Quotient(double num1, double num2)
        {
            return num1 / num2;
        }
    }

}
