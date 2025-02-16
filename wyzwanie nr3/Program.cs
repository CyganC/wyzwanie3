
namespace wyzwanie_nr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz liczbę");
            var liczba = GetNumber();
            
        }
        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(),  out int a))
                {
                    Console.WriteLine("Wprowadź liczbę!!");
                    continue;
                }
                if ((a % 2) == 0 && a!=0)
                {
                    Console.WriteLine("wpisałeś liczbę parzystą");
                }
                else if ((a % 2) == 1)
                {
                    Console.WriteLine("wpisałeś liczbę nieparzystą");
                }
                else if (a==0)
                {
                    Console.WriteLine("Wprowadziłeś zero");
                }
                //return a;
            }
        }
    }
}
