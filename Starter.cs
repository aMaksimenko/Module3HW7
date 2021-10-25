using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Starter
    {
        public async Task TaskRunAsync()
        {
            var taskOne = Task.Run(() => Console.WriteLine("Hello"));
            var taskTwo = Task.Run(() => Sum(2, 5));
            var taskThree = Task.Run(() => Sum(10, 20));

            var tasksList = new List<Task>();

            tasksList.Add(taskOne);
            tasksList.Add(taskTwo);
            tasksList.Add(taskThree);

            await Task.WhenAll(tasksList);
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Del(int a, int b)
        {
            return a - b;
        }
    }
}