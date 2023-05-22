using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    internal class Goal
    {

        private float minute;
        private bool isAuto;
        private FootballPlayer player;
        public float Minute {get { return minute; } }
        public bool IsAuto { get { return isAuto; } }
        public FootballPlayer Player { get { return player; } }



        public Goal(float _minute, FootballPlayer _player, bool _isAuto) { 
            minute = _minute;
            player = _player;
            isAuto = _isAuto;
        }
    }
}
