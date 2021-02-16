using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleExampleProject
{
    class TaskExample
    {

        static void Main(string[] s)
        {
            Task<string> sampleTask1 = Task.Run(() => {
                Thread.Sleep(1000);
                return "Hello1"; 
            });
            Console.WriteLine(sampleTask1.Result);
            Task<string> sampleTask2 = Task.Run(() => {
                Thread.Sleep(500);
                return "Hello2";
            });
            Console.WriteLine(sampleTask2.Result);
            Task<string> sampleTask3 = Task.Run(() => {
                Thread.Sleep(500);
                return "Hello3";
            });
            //Console.WriteLine(sampleTask1.Result);
            //Console.WriteLine(sampleTask2.Result);
            Console.WriteLine(sampleTask3.Result);
            Console.ReadKey();
        }
    }
}
