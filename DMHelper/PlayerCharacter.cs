using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHelper
{
    class PlayerCharacter
    {
        protected int hitpoints;
        protected int Str;
        protected int Con;
        protected int Cha;
        protected int Wis;
        protected int Int;
        protected int Dex;
        protected string Class;
        protected string Race;
        protected string playerName;
        protected List<string> notableItems;
        protected int level;
        protected string Subclass;
        protected string additionalInfo;

        public PlayerCharacter()
        {
            hitpoints = 10;
            Str = 10;
            Con = 10;
            Cha = 10;
            Wis = 10;
            Int = 10;
            Dex = 10;
            Class = "none";
            Race = "Human";
            playerName = "default";
            level = 1;
            Subclass = "none";

        }

        public void setHitpoints(int h)
        {
            hitpoints = h;
        }

        public void setLevel(int l)
        {
            level = l;
        }

        public void setStr(int s)
        {
            Str = s;
        }

        public void setWis(int w)
        {
            Wis = w;
        }

        public void setInt(int i)
        {
            Int = i;
        }

        public void setCha(int c)
        {
            Cha = c;
        }

        public void setCon(int c)
        {
            Con = c;
        }

        public void addItem(string s)
        {
            notableItems.Add(s);
        }

        public void setClass(string s)
        {
            Class = s;
        }

        public void setRace(string s)
        {
            Race = s;
        }

        public void setName(string s)
        {
            playerName = s;
        }

        public void setSub(string s)
        {
            Subclass = s;
        }

        public void addInfo(string s)
        {
            additionalInfo += "\n" + s + "\n";
        }
    }
}
