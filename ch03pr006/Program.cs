namespace ch03pr006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Python");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("============================================================== ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" 请输入搜索词：");
            string words = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Python  " + words);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ============================================================== ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" 请输入搜索词：");
            Console.ReadLine();
        }
    }
}
