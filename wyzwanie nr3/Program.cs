
namespace wyzwanie_nr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz liczbę");//komunikat "Wprowadz liczbę"
            var liczba = GetNumber();// Prywatna statyczna metoda
            
        }
        private static int GetNumber()
        {
            while (true)//Pętla nieskończona
            {
                if (!int.TryParse(Console.ReadLine(),  out int a))//Warunek inta
                {
                    Console.WriteLine("Wprowadź liczbę!!");
                    continue;
                }
                if ((a % 2) == 0 && a!=0)//Warunek parzystości
                {
                    Console.WriteLine("wpisałeś liczbę parzystą");
                }
                else if ((a % 2) == 1)//Warunek nieparzystości
                {
                    Console.WriteLine("wpisałeś liczbę nieparzystą");
                }
                else if (a==0)//Warunek zera
                {
                    Console.WriteLine("Wprowadziłeś zero");
                }
                //return a;
            }
        }
    }
}
