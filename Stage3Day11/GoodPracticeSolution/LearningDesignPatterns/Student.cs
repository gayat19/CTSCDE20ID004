using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    class Student : Senior
    {
        public Student(string name) : base(name)
        {

        }

        public override void Add(Senior senior)
        {
            Console.WriteLine("Student is the junior most so cannot add more");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string(' ',depth)+Name);
        }

        public override void Remove(Senior senior)
        {
            Console.WriteLine("Student is the junior most.. Nothing to remove");
        }
    }
}
