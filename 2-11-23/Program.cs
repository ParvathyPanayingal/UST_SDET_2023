﻿


/*class ThreadsEx
{
    static void Main()
    {
        // Create two threads
        Thread thread1 = new Thread(T1);
        Thread thread2 = new Thread(T1);

        // Start the threads
        thread1.Start();
        thread2.Start();

        // Wait for the threads to finish
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Both threads have completed their work.");
    }

    static void T1()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + " is working: " + i);
            Thread.Sleep(100); // Simulate some work
        }
    }
}*/

using ThreadsEx;
class Program
{
    static void Main()
    {
        Warehouse warehouse = new Warehouse();

        Thread worker1 = new Thread(() => warehouse.AddBox(1));
        Thread worker2 = new Thread(() => warehouse.AddBox(2));

        worker1.Start();
        worker2.Start();

        worker1.Join();
        worker2.Join();

        Console.WriteLine("Work completed. Total boxes in the warehouse: " + warehouse.GetTotalBoxes());
    }
}

