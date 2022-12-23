namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            Console.WriteLine("Enter The Fitst Number: ");

            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter The Second Number: ");

            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPerfect numbers between {0} and {1} are: ", n1, n2);
            for (int n = n1; n <= n2; n++)
            {
               int sum = 0;
                for (int i=1; i < n;i++)
                {
                    if (n % i == 0)
                        sum = sum + i;
                }
                if (sum == n)
                    Console.WriteLine("{0} ", n);
            }
            Console.Write("\n");
        }
    }
}