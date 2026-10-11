namespace ch05ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("{0:C}", 1251 + 3950));
            Console.WriteLine(string.Format("{0:E}", 120000.1));
            Console.WriteLine(string.Format("{0:N0}", 12800));
            Console.WriteLine(string.Format("{0:F2}",Math.PI));
            Console.WriteLine(string.Format("{0:X4}",33));
            Console.WriteLine(string.Format("{0:P0},{1:P0}",0.01,0.99));
            Console.ReadLine();

        }
    }
}
