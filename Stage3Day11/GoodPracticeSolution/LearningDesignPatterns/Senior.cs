using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    abstract class Senior
    {
        public string Name;
        public Senior(string name)
        {
            Name = name;
        }
        public abstract void Add(Senior senior);
        public abstract void Remove(Senior senior);
        public abstract void Display(int depth);
    }
}
