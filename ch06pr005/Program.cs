namespace ch06pr005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("你想获得几层金字塔");
                int n = Convert.ToInt32 (Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n-i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1;j<=2*i-1;j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();




                    
            }

                
            }
        }
    }


