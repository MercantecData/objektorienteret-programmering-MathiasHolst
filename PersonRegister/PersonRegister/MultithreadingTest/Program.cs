using System;
using System.Threading.Tasks;
using Multithreading;

namespace MultithreadingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            Timer test = new Timer();
            var task = Timer.GuessANumber(10, 10);
            int rnd = randomNumber.Next(1, 11);

            int guess = 12;

            while (guess != rnd)
            {
                guess = int.Parse(Console.ReadLine());


                if (guess == rnd)
                {
                    Console.WriteLine("You guessed it!");
                    Timer.StopTasks();
                }
                if (task.IsCompleted) return;
            }
            Task.WaitAll(task);
        }
    }
}
