namespace CALCULATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOperation;
            double firstOperand, secondOperand, result = 0;
            char userInput;
            bool work = true;

            while (work)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    firstOperand = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nВведите второе число: ");
                    secondOperand = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nВведите номер операции: (1:+ 2:- 3:* 4:/ 5:^): ");
                    numOperation = Convert.ToInt32(Console.ReadLine());
                    if (numOperation != 1 && numOperation != 2 && numOperation != 3 && numOperation != 4 && numOperation != 5)
                    {
                        Console.WriteLine("\nВведены некорректные данные!");
                        Console.ReadKey();
                        continue;
                    }
                }


                catch
                {
                    Console.WriteLine("\nВведены некорректные данные!");
                    Console.ReadKey();
                    continue;
                }


                if (secondOperand == 0 && numOperation == 4) Console.WriteLine($"\nРезультат: Бесконечность");


                else
                    result = CALCULATOR.Count(numOperation, firstOperand, secondOperand);
                Console.WriteLine($"\nРезультат: {result}");
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Желаете продолжить?(Y/N) (По умолчанию: N)");
                        userInput = Convert.ToChar(Console.ReadLine());
                        if (userInput == 'Y' || userInput == 'y') break;
                        else
                        {
                            work = false;
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nВведены некорректные данные!");
                        Console.ReadKey();
                        continue;
                    }


                }
            }
        }
    }
}