namespace OperatorExercise
{
    public class Program
    {
        
        static void Main(string[] args)
        {
             int a = 17;

             int b = 4;

             int sum = a + b;
             Console.WriteLine($"{a}+{b} is {sum}");

             int subtract = a - b;
             Console.WriteLine($"{a}-{b} is {subtract}");

             int multiply = a * b;
             Console.WriteLine($"{a}*{b} is {multiply}");

             int quotient = a / b;
             Console.WriteLine($"{a}/{b} is {quotient}");

             int remainder = a % b;
             Console.WriteLine($"{a}%{b} is {remainder}");

             Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
        }
        
    }
}
    

