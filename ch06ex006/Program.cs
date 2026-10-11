namespace ch06ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iSum = 0;
            for(int i = 1; i <= 100; i++)
            {
                iSum += i;
            }
            Console.WriteLine(iSum);
            Console.ReadLine();
        }
    }
}
