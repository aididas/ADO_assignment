using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoassignment
{
    public class Member
    {
        public String name { get; set; }
        public double balance { get; set; }

        public Member(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public Member(string name)
        {
            this.name = name;
            balance = 0;
        }

        public override string ToString()
        {
            return name + " " + balance.ToString() ;
        }
    }
}
