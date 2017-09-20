using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoldTheDoor
{
    class Wizard : Character
    {
        private int magic;
        private string name;
        public Wizard(int magic, string name): base(name)
        {
            this.magic = magic;
            this.name = name;
            hp = 10;
        }
        public int Magic
        {
            get { return magic; }
        }
        public override void Battle(ref Character c)
        {

        }
    }
}
