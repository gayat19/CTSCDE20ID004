using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleExampleProject
{
    class Program
    {
        void Print100To1000()
        {
            for (int i = 100; i < 1001; i = i + 100)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Therad is " + Thread.CurrentThread.Name + "   " + i);
            }
        }
        void PrintTemTo100()
        {
            lock (this)
            {
                for (int i = 10; i < 101; i = i + 10)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Therad is " + Thread.CurrentThread.Name + "   " + i);
                }
            }
        }
        void Add(int num1,int num2)
        {
            Console.WriteLine("2 int Add method");
        }
        //void Add(int num1, int num2,int num3)
        //{
        //    Console.WriteLine("3 int Add method");
        //}
        void Add(int num1, int num2, int num3,int num4=3)
        {
            Console.WriteLine("4 int Add method");
        }
        void OtherCSharpThings()
        {
            //Add(10, 20, 30);
            //checked
            //{
            //    int num = int.MaxValue;
            //    Console.WriteLine(num);
            //    num++;
            //    Console.WriteLine(num);
            //}
            //Nullable<int> num2 = 23;
            int? num2 = 23;
            int sum = num2??0 + 10;
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //Thread t1 = new Thread(program.PrintTemTo100);
            //t1.Name = "First";
            //Thread t2 = new Thread(program.PrintTemTo100);
            //t2.Name = "Second";
            //t1.Start();
            //t1.Join();
            //t2.Start();
            program.OtherCSharpThings();
            //program.PrintTemTo100();
            //program.Print100To1000();
            Console.ReadKey();
        }
    }
}
