using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    abstract class MyIteraror
    {
        public abstract object First();
        public abstract object GetCurrentItem();
        public abstract object Next();
        public abstract bool IsLast();
    }
}
