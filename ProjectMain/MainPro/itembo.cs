using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPro
{
    class itembo
    {
        static List<items> ilist = new List<items>();
        static List<SubCategory> clist = new List<SubCategory>();
        public void additems(int Ino, int price,string itname, string desit, int soc, string re, string Cna, int Cid, string Subnmae,string des, int sid,string sellerid) { 
            SubCategory sub_cat = new SubCategory(Cid, Subnmae, des,Cna,sid);
            items item=new items(Ino, price, itname,desit, soc, re,sellerid,sub_cat);
            clist.Add(sub_cat);
            ilist.Add(item);
        }
        public void Display()
        {
            foreach (var e in ilist)
                Console.WriteLine(e.ToString());
            foreach (var n in clist)
                Console.WriteLine(n.ToString());
        }
        public void Search()
        {
            Console.WriteLine("1:Search by item id \n 2: item name \n 3:price ");
            Console.WriteLine("Enter your Choice:");
            int n = Convert.ToInt32(Console.ReadLine());
            int Fla = 0;
            if (n == 1)
            {
                Console.WriteLine("enter your itrem id:");
                int id = Convert.ToInt32(Console.ReadLine());
                
                foreach (items i in ilist)
                {
                    if (i.Id == id)

                        Console.WriteLine(" item id:" + i.Id + "" + i.Item_name + " " + i.Stock_number + " " + i.Price + " " + i.Description);

                    else
                        Fla = 1;
                }
            }
            else if (n == 2)
            {
                Console.WriteLine("enter the item name to search:");
                string na = Console.ReadLine();
                Console.WriteLine("Item Id Item Name Item Qunatity Item Price Item Desc");
                foreach (items i in ilist)
                {
                    if (i.Item_name == na)
                    {
                        Console.WriteLine("Item Id Item Name Item Qunatity Item Price Item Desc");
                        Console.WriteLine(i.Id + " " + i.Item_name + " " + i.Stock_number + " " + i.Price + " " + i.Description);
                    }
                    else
                        Fla = 1;
                }
            }
            else if (n == 3)
            {
                Console.WriteLine("enter the min nd max range of price u want to search:");
                int primin = Convert.ToInt32(Console.ReadLine());
                int primax = Convert.ToInt32(Console.ReadLine());
                List<items> p = ilist.FindAll(e => e.Price > primin && e.Price < primax);
                foreach (items r in p)
                {
                    Console.WriteLine(r.ToString());
                }

            }

            if (Fla == 1)
                Console.WriteLine("Item not Found");
        }
    }
}
