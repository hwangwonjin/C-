using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_2
{
    internal class Student : Object 
    {
        public string Name {  get; set; }
        public Sex StudentSex { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return $"{Name} [{StudentSex}] [{Score}]";
        }
    }
}
