namespace ch06pr003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "经典数组";
            int first = 1;
            int second=1,third=0;
            for (int i = 2; i < 30; i++)
            {
                third = first + second;
                first = second;
                second = third;
                
                
            }
            Console.WriteLine(third);
        }
    }
}
