namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            string userInput = Console.ReadLine();
            int number;

            if (int.TryParse(userInput, out number))
            {
                Console.WriteLine("You have entered an integer " + number);
            }
            else
            {
                Console.WriteLine("It's not an integer. Please, try again.");
            }


        }
    }
}

