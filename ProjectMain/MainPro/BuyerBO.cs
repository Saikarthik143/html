using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPro
{
    class BuyerBO
    {

        static List<Buyer> b = new List<Buyer>();
        itembo bo = new itembo();
        public void CreateBuyer(string s,string em,string pd,string address,int mobile)
        {
           
            b.Add(new Buyer(s, em, pd, address, mobile));
        }
      public bool CheckBuyer(string i,string n) {
            Buyer b2 = b.Find(e => e.N == i && e.Pd == n);

            if (b2 != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayItems()
        {//item bo obj displ items list
            Console.WriteLine("display emp details:");
            foreach (Buyer b3 in b)
            {
                Console.WriteLine(b3.ToString());
            }
        }
        public void display()
        {
            bo.Display();
        }
        public void Search()
        {
            bo.Search();
        }
    }
}
