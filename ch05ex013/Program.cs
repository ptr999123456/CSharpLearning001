namespace ch05ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = ".NET也开源了！";
            string str2 = str1.Remove(0,4);
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
