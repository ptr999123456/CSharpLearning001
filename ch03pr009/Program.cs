namespace ch03pr009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("计算牛奶的蛋白质含量");
            Console.WriteLine("您购买的袋数");
            int a = Convert.ToInt16(Console.ReadLine());
            double b = 6.4;
            Console.WriteLine(a*b);
        }
    }
}
