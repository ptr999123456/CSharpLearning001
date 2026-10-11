namespace ch03pr003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            Console.WriteLine("请输入圆的半径：");
            double r = Convert.ToDouble(Console.ReadLine());
            double area = PI * r * r;
            Console.WriteLine("圆的面积是{0}", area);
        }
    }
}
