using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Exer1Solution
{
    class Program
    {
        /// <summary>
        /// To run this program, please run "dotnet run" in the folder of "Exer1Server", the API server for the solution.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Solution for Exer 1");            
            var task = DoRunAsync();
            task.Wait();            
            Console.WriteLine(task.Result.ToString());
            Console.WriteLine(string.Format("Main thread completed"));
            Console.ReadKey();
        }

        private static async Task<string> DoRunAsync()
        {
            using (HttpClient hc = new HttpClient())
            {
                CancellationToken ct = new CancellationToken();
                var task1 = hc.GetStringAsync("http://localhost:5000/api/values/GetStr1");
                var task11 = hc.GetAsync("http://localhost:5000/api/values/GetStr1", HttpCompletionOption.ResponseHeadersRead, ct);
                var task2 = hc.GetStringAsync("http://localhost:5000/api/values/GetStr2");
                var task3 = hc.GetStringAsync("http://localhost:5000/api/values/GetStr3");
                await Task.WhenAll(task1, task2, task3);

                //Press key "1" to exit the tasks.
                char key = Console.ReadKey().KeyChar;
                if (key == '1')
                {
                    ct.ThrowIfCancellationRequested();
                }
                string result = task1.Result.ToString() + task2.Result.ToString() + task3.Result.ToString();
                return result;
            }
        }
    }
}
