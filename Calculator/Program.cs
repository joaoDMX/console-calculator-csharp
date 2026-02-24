namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool calculatorRunning = true;

            while (calculatorRunning)
            {
                double num = 0;
                Console.Write("Insert a number (0 to exit): ");

                while (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("\nInvalid input!\n");
                }

                if (num == 0)
                {
                    break;
                }

                Calculator.Initialization(num);

                while (true)
                {
                    char operation;
                    Console.WriteLine("\n[+] Addition\n[-] Subtraction\n[*] Multiplication\n[/] Division\n[c] Clear\n[e] Exit\n");

                    while(!char.TryParse(Console.ReadLine(), out operation))
                    {
                        Console.WriteLine("Invalid operation!");
                    }

                    if (operation == 'e')
                    {
                        calculatorRunning = false;
                        break;
                    }

                    if (operation == 'c')
                    {
                        Calculator.Clear();
                        Console.WriteLine($"\nResult: {Calculator.Result}\n");
                        continue;
                    }

                    Console.Write("\nInsert another number: ");
                    while (!double.TryParse(Console.ReadLine(), out num))
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    switch (operation)
                    {
                        case '+':
                            Calculator.Addition(num);
                            break;
                        case '-':
                            Calculator.Subtraction(num);
                            break;
                        case '*':
                            Calculator.Multiplication(num);
                            break;
                        case '/':
                            Calculator.Division(num);
                            break;
                        default:
                            Console.WriteLine("\nInvalid operation!");
                            Calculator.Clear();
                            break;
                    }
                    Console.WriteLine($"\nResult: {Calculator.Result}\n");
                }
            }
        }
    }
}