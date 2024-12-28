using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        int firstNum;
        int secondNum;
        int result = 0;
        char mathAction;

        do
        {
            try
            {
                Console.WriteLine("Введіть перше число: ");
                firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть друге число: ");
                secondNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть математичну дію: +, -, *, / ");
                mathAction = Convert.ToChar(Console.ReadLine());
                switch (mathAction)
                {

                    case '+':
                        result = firstNum + secondNum;
                        break;
                    case '-':
                        result = firstNum - secondNum;
                        break;
                    case '*':
                        result = firstNum * secondNum;
                        break;
                    case '/':
                        try 
                        {
                            result = firstNum / secondNum;
                        }
                        catch
                        {
                            Console.WriteLine("Ділення на 0 неможливе");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Некоректна математична дія");
                        continue;
                }
                Console.WriteLine($"Результат: {firstNum} {mathAction} {secondNum} = {result}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Введіть ціле число");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка {ex.Message}");
            }
        } while (true) ;
    }
}