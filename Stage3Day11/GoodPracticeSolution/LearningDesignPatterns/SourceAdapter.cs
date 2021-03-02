using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    class SourceAdapter : ChangeClass,ISource
    {
        public void CheckSource()
        {
            //Console.WriteLine("Call for CheckSource");
            ChangedMethod();
        }
    }
}
