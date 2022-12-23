namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Enter The Fitst Number: ");

            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter The Second Number: ");

            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPrime numbers between {0} and {1} are: ", n1, n2);

            for (int i = n1; i <= n2; i++)
            {
                int j;

                for (j = 2; j < i ; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                    if (j == i)
                    Console.WriteLine(i);
            }
        }
    }
}
            
