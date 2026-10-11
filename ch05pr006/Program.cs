using System.Text;

namespace ch05pr006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("yuanshen");
            sb.Insert(0, "heeelllo ");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
