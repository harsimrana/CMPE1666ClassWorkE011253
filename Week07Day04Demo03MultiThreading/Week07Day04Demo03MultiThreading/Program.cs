using System.Threading;

namespace Week07Day04Demo03MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thread Objects
            Thread t1 = null, t2 = null, t3= null;

            // Assigning different method to different threads

            t1 = new Thread(DisplayMessage);
            t2= new Thread(FindSine);
            t3= new Thread(FindCos);

            // Starting all my threads 
            t1.Start();
            t2.Start();
            t3.Start();

            //DisplayMessage();
            //FindSine();
        }

        public static void DisplayMessage()
        { 
            for(int i =0; i<=100; ++i)
            {
                Console.WriteLine("Hello Message from Simran");
                Thread.Sleep(100);
            }
        }

        public static void FindSine()
        {
            for(int i=0; i<=180; i++)
            {
                double rad = Math.PI * i / 180;
                double sinValue = Math.Sin(rad);

                Console.WriteLine($"{i} degrees = {rad} = Sin = {sinValue} ");
                Thread.Sleep(100);

            }
        }

        public static void FindCos()
        {
            for (int i = 0; i <= 180; i++)
            {
                double rad = Math.PI * i / 180;
                double cosValue = Math.Cos(rad);

                Console.WriteLine($"{i} degrees = {rad} = Cos = {cosValue} ");
                Thread.Sleep(100);

            }
        }


    }
}
