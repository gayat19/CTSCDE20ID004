using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    class ConnectionSingleton
    {
        public  int check { get; set; }
        private static ConnectionSingleton _myObject;
        private ConnectionSingleton()
        {
            check++;
        }
        public static ConnectionSingleton GetInstance()
        {
            if (_myObject == null)
                _myObject = new ConnectionSingleton();
            return _myObject;
        }
    }
}
