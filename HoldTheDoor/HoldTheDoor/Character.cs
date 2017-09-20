using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoldTheDoor
{
    public abstract class Character
    {
        private string name;
        private bool interested;
        protected int level;
        protected int hp;

        public Character(string name)
        {
            this.name = name;

        }
        public string Name
        {
            get { return name; }
        }
        public int Hp
        {
            get { return hp; }
        }
        public bool Interested
        {
            get; set;
        }
        public int Level
        {

            get;set;
        }

        public abstract void Battle(ref Character c);
    }
}
