using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atomiki_ergasia_2_monadwn
{
    class User
    {
        public User()
        {

        }

        public User(String Name, String Score)
        {
            this.Name = Name;
            this.Score = Score;
        }

        public String Name;
        public String Score;
    }
}
