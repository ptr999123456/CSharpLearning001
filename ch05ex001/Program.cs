namespace ch05ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a= 'A';
            char b = '1';
            char c = '*';
            char d = ',';
            char e = '|';
            char f = ' ';
            Console.WriteLine(Char.IsLetter(a));
            Console.WriteLine(Char.IsDigit(b));
            Console.WriteLine(Char.IsLetterOrDigit(c));
            Console.WriteLine(Char.IsPunctuation(d));
            Console.WriteLine(Char.IsSeparator(e));
            Console.WriteLine(Char.IsWhiteSpace(f));
            Console.ReadLine();

        }
    }
}
