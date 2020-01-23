using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPro
{
    class SellerBO
    {
        static List<Seller> slist = new List<Seller>();
        public void CreateSeller(string s, string em, string pd, string address, int mobile,string com)
        {
            slist.Add(new Seller(s, em, pd, address, mobile,com));
        }
        public void DisplayItems()
        {//item bo obj displ items list
            Console.WriteLine("display emp details:");
            foreach (Seller b3 in slist)
            {
                Console.WriteLine(b3.ToString());
            }
        }
        public bool CheckSeller(string i, string n)
        {
            Seller s2 = slist.Find(e => e.N1 == i && e.Pd1 == n);
            
                    if (s2!=null)
                    {
                return true;
                    }
                    else
                    {
                return false;
                    }
        }
        public void additems()
        {
            
            
        }
       
    }
}
    

