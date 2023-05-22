﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{


    internal class Person
    {
        private string _name;
        private int _age;
        

        internal string Name { get { return _name; } }
        internal int Age { get { return _age;} }

        
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

    }
}
