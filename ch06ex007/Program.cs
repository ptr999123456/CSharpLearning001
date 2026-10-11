namespace ch06ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int irow, icolumn;
            for (irow = 1; irow < 10; irow++)
            {
                for (icolumn = 1; icolumn <= irow; icolumn++)
                {
                    Console.Write("{0}*{1}={2}",icolumn, irow,irow*icolumn);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
