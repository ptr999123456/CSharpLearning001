namespace ch04pr007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "假设你刚被mipso公司录用，公司正在做一个的大型数据项目，你被安排做验证模块，其中一个工作是生成数字计算的验证码，如生成3*9=？，8+3=？（用random方法去随机生成用于作为验证码的数字";
            Random rnd = new Random();
            int num1 = rnd.Next(9);
            int num2 = rnd.Next(9);
            int num3 = rnd.Next(9);
            int num4 = rnd.Next(9);
            Console.WriteLine(num1+num2);
            Console.WriteLine(num3*num4);
        }
    }
}
