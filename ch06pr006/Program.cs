using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ch06pr006
{
    internal class Program
    {

        static void PrintLayer(int layer)
        {
            for (int i = 1; i <= layer; i++)
            {
                //输入空格
                for (int j = 1; j <= layer - i; j++)
                {
                    Console.Write(" ");
                }
                //输入星星
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
        static void Main(string[] args)
        {
            
            Console.Title = "金字塔";
            while (true)
            {
                Console.WriteLine("请输入你要多少行金字塔");
                int layer = 0;
                string slayer = Console.ReadLine();
                if (slayer == "x")
                {
                    break;
                }
                bool blayer = Int32.TryParse(slayer, out layer);
                if (blayer)
                {
                    //do something later
                }
                else
                {
                    Console.WriteLine("你输入的层数无效");
                }
                //PrintLayer(layer);
                Program.PrintLayer(layer);
                MyKing m = new MyKing(layer);
                m.PrintLayer();
            }
        }

    }
    class MyKing
    {
        int layer = 0;
        public MyKing(int l) 
        {
            layer = l;
            
        }
        public void PrintLayer()
        {
            for (int i = 1; i <= layer; i++)
            {
                //输入空格
                for (int j = 1; j <= layer - i; j++)
                {
                    Console.Write(" ");
                }
                //输入星星
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }

}
