using System.Text.RegularExpressions;

namespace ch05ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool b =  Regex.IsMatch(str,"^\\d{6}$");
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
