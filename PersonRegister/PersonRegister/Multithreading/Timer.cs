using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    public class Timer
    {
        private static CancellationTokenSource tokenSource = new CancellationTokenSource();
        public static Task GuessANumber(int seconds, int repeats)
        {
            CancellationToken token = tokenSource.Token;
            Task task = new Task(() =>
            {
                for(int i = 0; i < repeats && !token.IsCancellationRequested; i++)
                {
                    Console.WriteLine($"You have {seconds} seconds left!");
                    seconds -= 1;
                    if(!token.IsCancellationRequested) Task.Delay(1000).Wait();
                }
            });
            task.Start();



            return task;
        }

        public static void StopTasks()
        {
            tokenSource.Cancel();
        }
    }
}
