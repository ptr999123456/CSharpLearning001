using System.ComponentModel.DataAnnotations;

namespace ch05pr004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "手机";
            string a = "1,苹果 6888\n2,华为 10000\n3,三星 4999";
            Console.WriteLine(a);
            Console.WriteLine("请输入商品编号");
            while (true)
            {
                int m = Convert.ToInt16(Console.ReadLine());
                if (m == 1)
                {
                    Console.WriteLine("苹果,{0:C}",6888);
                }
                else if (m == 2)
                {
                    Console.WriteLine("华为,{0:C}",10000);
                }
                else if (m == 3)
                {
                    Console.WriteLine("三星,{0:C}",4999);
                }
                else
                {
                    Console.WriteLine("您所查询的商品不存在");
                }

            }
        }
    }
}
