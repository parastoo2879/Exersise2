namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  i = 0;
            int count = 1;
            while (i<=20)
            {


                if (i % 2 == 0)
                {
                    
                    Console.WriteLine($" Number {count} : {i}");
                    count++;
                }
              
                i++;
            }

            Console.ReadKey();
        }
    }
}
