using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuTest.Classes
{
    public class Player
    {
        public String name { get; set; }
        private int lvl { get; set; }
        private int exp { get; set; }

        public Player(string name)
        {
            this.name = name;
            this.lvl = 1;
            this.exp = 0;

        }

    }


}
