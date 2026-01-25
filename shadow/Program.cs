namespace shadow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("mene eded gonder");
            //int a = Convert.ToInt32 (Console.ReadLine());

            // switch (a)
            // {
            //     case 1:
            //         Console.WriteLine("3 cu gun");
            //         break;
            //     default: 
            //      Console.WriteLine("default");
            //         break;
            // }
            
                Console.WriteLine("istifadeciden 3 reqem alib arasinda en boyuk reqemi tap");

                int on = Convert.ToInt32(Console.ReadLine());
                int iyirmi = Convert.ToInt32(Console.ReadLine());
                int otuz = Convert.ToInt32(Console.ReadLine());
            
            if (on > iyirmi && on > otuz)
            {
                Console.WriteLine("en boyuk eded " +on);
            }
            else if (iyirmi > on && iyirmi > otuz)
            {
                Console.WriteLine("en boyuk eded " +iyirmi);
            }
            else
            {
                Console.WriteLine("en boyuk eded " +otuz);
            }

        }

     }
    
}
