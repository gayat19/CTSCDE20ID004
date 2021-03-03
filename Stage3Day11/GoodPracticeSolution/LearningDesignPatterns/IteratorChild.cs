using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    class IteratorChild:MyIteraror
    {
        private AggregateChild aggregateChild;
        private int _current = 0;
        public IteratorChild(AggregateChild aggregateChild)
        {
            this.aggregateChild = aggregateChild;
        }

        public override object First()
        {
            return aggregateChild[0];
        }

        public override object GetCurrentItem()
        {
            return aggregateChild[_current];
        }

        public override bool IsLast()
        {
            if (_current >= aggregateChild.Count)
                return true;
            return false;
        }

        public override object Next()
        {
            object result = null;
            if (_current < aggregateChild.Count-1)
            {
                _current++;
                result = aggregateChild[_current];
            }
            return result;
        }
    }
}
