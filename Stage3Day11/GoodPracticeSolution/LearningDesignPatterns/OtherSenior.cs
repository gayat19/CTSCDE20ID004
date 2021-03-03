using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    class OtherSenior : Senior
    {
        List<Senior> _seniors = new List<Senior>();

        public OtherSenior(string name) : base(name)
        {
        }

        public override void Add(Senior senior)
        {
            _seniors.Add(senior);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('*', depth) + Name);
            foreach (var item in _seniors)
            {
                item.Display(depth + 2);
            }
        }

        public override void Remove(Senior senior)
        {
            _seniors.Remove(senior);
        }
    }
}
