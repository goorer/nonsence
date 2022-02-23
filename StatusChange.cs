using System;
using System.Threading;

public class StatusChange
{
    static public void Main()
    {
        int x = 50;
        int end = 0;
        Random random = new Random();

        try
        {
            while (true)
            {
                if (end == 50)
                {
                    break;
                }
                for (int i = 0; i < x; i++)
                {
                    Console.Write("#");
                    Thread.Sleep(500);
                }

                Console.WriteLine("done");
                Thread.Sleep(300);
                Console.WriteLine("New Target Load....");

                int sleepTime = 1000 * random.Next(1,5);

                Thread.Sleep(sleepTime);

                if (random.Next(1, 10) == 3)
                {
                    Console.WriteLine("Extention!!!!!");
                    Console.WriteLine("UnLoad...");
                    Console.WriteLine("New Target Load....");
                }

                end++;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}