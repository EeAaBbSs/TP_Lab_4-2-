using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    class InteriorWall : Wall
    {
        private int _hp = 100;
        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
    }
}
