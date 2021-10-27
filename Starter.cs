using System;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Starter
    {
        private readonly CancellationTokenSource _cancellationTokenSource;

        public Starter()
        {
            _cancellationTokenSource = new CancellationTokenSource();
        }

        public void Run()
        {
            var task = Task.Run(() => Fib(50));

            Thread.Sleep(5000);
            _cancellationTokenSource.Cancel();
            Console.WriteLine(task.Result);
        }

        public int Fib(int n1)
        {
            if (_cancellationTokenSource.Token.IsCancellationRequested)
            {
                return n1;
            }

            if (n1 <= 2)
            {
                return 1;
            }
            else
            {
                return Fib(n1 - 1) + Fib(n1 - 2);
            }
        }
    }
}