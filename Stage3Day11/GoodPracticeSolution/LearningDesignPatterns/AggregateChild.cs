using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LearningDesignPatterns
{
    class AggregateChild : MyAggregate
    {
        private ArrayList _myItems = new ArrayList();
        public override MyIteraror GetIterator()
        {
            return new IteratorChild(this);
        }
        public int Count
        {
            get{ return _myItems.Count; }
        }
        public object this[int index]
        {
            get { return _myItems[index]; }
            set { _myItems.Insert(index,value); }
        }
    }
}
