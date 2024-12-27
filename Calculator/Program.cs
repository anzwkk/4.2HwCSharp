using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        int firstNum;
        int secondNum;
        int result = 0;
        char mathAction;

        Console.WriteLine("vvedite pervoe chislo: ");
        firstNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("vvedite vtoroe chislo: ");
        secondNum = Convert.ToInt32(Console.ReadLine());

        do
        {
            try
            {
                Console.WriteLine(" +,-,*,/ ");
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
                        result = firstNum / secondNum;
                        break;
                    default:
                        Console.WriteLine("Nekorektna matem diya");
                }
                Console.WriteLine($"Resultat {firstNum} {mathAction} {secondNum} = {result}");

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