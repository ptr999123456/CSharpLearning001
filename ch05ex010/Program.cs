namespace ch05ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string StrA = "AI的时代已经到来,你还在等待什么";
            char[] separator = {',' };
            String[] splitstrings = new String[100];
            splitstrings = StrA.Split(separator);
            for(int i = 0; i < splitstrings.Length; i++)
            {
                Console.WriteLine("item{0}:{1}",i,splitstrings[i]);
            }
            Console.ReadLine();

        }
    }
}
