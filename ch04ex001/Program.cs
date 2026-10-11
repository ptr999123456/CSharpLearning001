namespace ch04ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "计算器";
            Console.Write("第一个数字");
            double a = double.Parse(Console.ReadLine());
            Console.Write("第二个数字");
            double b = double.Parse(Console.ReadLine());
            Console.Write("第三个数字");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("求余{0},{1},{2},{3}",a,b,c,a%b%c);
            Console.ReadLine();
        }
    }
}
