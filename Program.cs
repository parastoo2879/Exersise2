namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i<=20;i++)
            //{
            //    Console.Write($"Number {i +1} ");
            //    if (i % 2 == 0) Console.Write($"{i}  \n");

            //}

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
