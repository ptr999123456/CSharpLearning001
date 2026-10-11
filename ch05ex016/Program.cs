namespace ch05ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "one world,one dream";
            string b = a.Replace(',', '*');
            Console.WriteLine(b);
            string c = a.Replace("one world","One World");
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
