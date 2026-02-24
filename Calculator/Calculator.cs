namespace Calculator
{
    internal static class Calculator
    {
        public static double Result { get; private set; }

        public static void Initialization(double num)
        {
            Result = num;
        }

        public static void Clear()
        {
            Result = 0;
        }

        public static void Addition(double num)
        {
            Result += num;
        }

        public static void Subtraction(double num)
        {
            Result -= num;
        }

        public static void Multiplication(double num)
        {
            Result *= num;
        }

        public static void Division(double num)
        {
            if(num == 0)
            {
                Console.WriteLine("\nDivision by 0 not possible!");
                Result = -1;
                return;
            }
            else
            {
                Result /= num;
            }
        }
    }
}
