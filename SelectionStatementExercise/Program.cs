namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var faveNum = 3;
            Console.WriteLine($"Can you guess my favorite number?");
            var UserInput = int.Parse(Console.ReadLine());

           if (UserInput == faveNum)
            {
                Console.WriteLine($"Great Job my favorite number is {faveNum}");

            }
           else if (UserInput > faveNum)
            {
                Console.WriteLine($"Too High");
            }

           if (UserInput < faveNum)
            {
                Console.WriteLine($"Too Low");
            }

        }
    }
}
