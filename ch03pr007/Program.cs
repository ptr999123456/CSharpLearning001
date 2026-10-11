namespace ch03pr007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("商品编号：");
            Console.WriteLine("商品名称：");
            Console.WriteLine("商品规格：");
            Console.WriteLine("商品价格：");
            Console.WriteLine("入库数量：");
            Console.WriteLine("请输入商品编号：");
            string a = Console.ReadLine();
            Console.WriteLine("请输入商品名称：");
            string b = Console.ReadLine();
            Console.WriteLine("请输入商品规格：");
            string c = Console.ReadLine();
            Console.WriteLine("请输入商品价格：");
            string d = Console.ReadLine();
            Console.WriteLine("请输入入库数量：");
            string e = Console.ReadLine();
            Console.WriteLine("商品入库单");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine("保存   取消");
        }
    }
}
