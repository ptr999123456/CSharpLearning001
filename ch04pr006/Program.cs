
namespace ch04pr006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "淘宝能量兑换红包";
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("你可以兑换的红包数量为{0}个",a/100);
            Console.ReadLine();
        }
    }
}
