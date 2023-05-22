using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    internal class FootballPlayer: Person
    {
        internal int _number;
        internal float _height;

        public FootballPlayer(string name, int number, int age, float height): base(name, age)
        {
            _number = number;
            _height = height;
        }
    }
}
