using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPro
{
    class Seller
    {
        int mob1;
        string n1, pd1, add1, email1,comp;
        public Seller()
        {
            
        }

        public int Mob1 { get => mob1; set => mob1 = value; }
        public string N1 { get => n1; set => n1 = value; }
        public string Pd1 { get => pd1; set => pd1 = value; }
        public string Add1 { get => add1; set => add1 = value; }
        public string Email1 { get => email1; set => email1 = value; }
        public string Comp { get => comp; set => comp = value; }

        public Seller(string name, string email, string pd, string address, int mob,string com)
        {
            this.n1 = name;
            this.Email1 = email;
            this.Pd1 = pd;
            this.Add1 = address;
            this.Mob1 = mob;
            this.comp = com;
        }
        public override string ToString()
        {
            return this.N1 + " " + this.Email1 + " " + this.pd1+ " " + this.Add1 + " " + this.Mob1+" "+this.Comp;
        }
        //public void Displaydetails()
        //{
        //    Console.WriteLine("The Items List:");
        //    Console.WriteLine("Id no:" +)
        //}
    }
}
