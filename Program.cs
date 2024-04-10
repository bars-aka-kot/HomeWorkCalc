namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                double num1 = int.Parse(args[0]);
                string operand = args[1];
                double num2 = int.Parse(args[2]);
                
                switch (operand)
                {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Неудачно");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Введите строку в формате " +
                    "число + (- * /) число");
            }
        }
    }
}
