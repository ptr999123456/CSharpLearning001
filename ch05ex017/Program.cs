using System.Text;

namespace ch05ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1000;
            StringBuilder honorvsxiaomi = new StringBuilder("荣耀自称科技标杆",100);
            honorvsxiaomi.Append( "vs小米死磕高性价比");
            Console.WriteLine(honorvsxiaomi);
            honorvsxiaomi.AppendFormat("{0:c}", num);
            Console.WriteLine(honorvsxiaomi);
            honorvsxiaomi.Insert(0, "PK:");
            Console.WriteLine(honorvsxiaomi);
            honorvsxiaomi.Remove(21, honorvsxiaomi.Length - 21);
            Console.WriteLine(honorvsxiaomi);
            honorvsxiaomi.Replace("PK", "相爱相杀");
            Console.WriteLine(honorvsxiaomi);
            Console.ReadLine();

        }
    }
}
