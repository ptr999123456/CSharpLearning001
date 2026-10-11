using System.Reflection.Metadata.Ecma335;
using System.Text;
namespace ch05ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            long starTime = DateTime.Now.Millisecond;
            for (int i = 0; i < 10000; i++)
            {
                str = str + i;
            }
            long endTime = DateTime.Now.Millisecond;
            long time = endTime - starTime;
            Console.WriteLine("String消耗时间："+time);
            StringBuilder builder = new StringBuilder("");
            starTime = DateTime.Now.Millisecond;
            for(int j = 0; j < 10000; j++)
            {
                builder.Append(j);
            }
            endTime= System.DateTime.Now.Millisecond;
            time = endTime - starTime;
            Console.WriteLine("StringBuilder消耗时间：" + time);
            Console.ReadLine();

        }
    }
}
