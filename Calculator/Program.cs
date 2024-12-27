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
            Console.WriteLine($"Resultat {firstNum} {secondNum} = {result}");
            } while (true) ;
    }
}