namespace ch05ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string StrA = "今天你消耗了多少卡路里";
            string StrB = "";
            StrB = StrA.Substring(2, 4);
            Console.WriteLine(StrB);
            Console.ReadLine();
        }
    }
}
