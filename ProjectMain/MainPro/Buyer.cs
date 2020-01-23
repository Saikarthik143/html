using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPro
{
    class Buyer
    {
        int mob;
        string n, pd, add, email;
        int n11;


        public int Mob { get => mob; set => mob = value; }
        public string N { get => n; set => n = value; }
        public string Pd { get => pd; set => pd = value; }
        public string Add { get => add; set => add = value; }
        public string Email { get => email; set => email = value; }
        public int N11 { get => n11; set => n11 = value; }

        public Buyer() { }
        public Buyer(string name,string email,string pd,string address,int mob)
        {
            this.N=name;
            this.Email = email;
            this.Pd = pd;
            this.Add = address;
            this.Mob = mob;

        }
        public override string ToString()
        {
            return this.N + " " + this.Email + " " + this.pd + " " + this.Add + " " + this.Mob;
        }
        
    }
}
