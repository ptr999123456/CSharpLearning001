namespace ch05ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "华为P30";
            string str2 = "华为P30 Pro";
            Console.WriteLine(String.Compare(str1, str2));
            Console.WriteLine(String.Compare(str1, str1));
            Console.WriteLine(String.Compare(str2,str1));
            Console.ReadLine();
            
        }
    }
}
