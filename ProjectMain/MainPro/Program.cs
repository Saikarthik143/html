using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPro
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                //Buyer b = new Buyer();
                BuyerBO b1 = new BuyerBO();
                SellerBO s1 = new SellerBO();
                itembo ibo = new itembo();
                Console.WriteLine("Menu 1:Buyer\n 2:Display Buyer \n 3:Seller\n 4:Display Seller");
                Console.WriteLine("enter your choice:");
                int ch = Convert.ToInt32(Console.ReadLine());
               
                bool flag = true;
                switch (ch)
                {

                    case 1:
                        Console.WriteLine("1:register\n2:Login");
                        int op = Convert.ToInt32(Console.ReadLine());
                        switch (op)
                        {
                            case 1:

                                int mob;
                                string n, pd, add, email;
                                Console.WriteLine("enter user name");
                                n = Console.ReadLine();
                                Console.WriteLine("enter email ");
                                email = Console.ReadLine();
                                Console.WriteLine("enter password");
                                pd = Console.ReadLine();
                                Console.WriteLine("Enterr your address");
                                add = Console.ReadLine();
                                Console.WriteLine("enter 10 digit mobile number:");
                                mob = Convert.ToInt32(Console.ReadLine());
                                b1.CreateBuyer(n, email, pd, add, mob);
                                Console.WriteLine("the elements are saved:");
                                // Console.WriteLine("display emp details:");
                                break;
                            case 2:
                                Console.WriteLine("Enter username: ");
                                string bid1 = (Console.ReadLine());
                                Console.WriteLine("enter password:");
                                string Password1 = Console.ReadLine();
                                flag = b1.CheckBuyer(bid1, Password1);
                                if (flag == true)
                                {
                                    Console.WriteLine("login Successful");
                                    while (true)
                                    {
                                        Console.WriteLine("1.Electronic 2.Homeappliances 3.Accessories ");
                                        Console.WriteLine("1:Display 2:Search \n  3:exit");
                                        int c = Convert.ToInt32(Console.ReadLine());
                                        if (c == 1)
                                            b1.display();
                                        else if (c == 2)
                                            b1.Search();
                                        else
                                            break;
                                    }
                                }
                                else
                                    Console.WriteLine("invalid credentials");

                                break;
                        }
                        break;

                    case 2:

                        b1.DisplayItems();
                        break;

                    case 3:
                        Console.WriteLine("1:register\n2:Login");
                        int op1 = Convert.ToInt32(Console.ReadLine());
                        switch (op1)
                        {
                            case 1:
                                int mob1;
                                string n1, pd1, co, add1, email1;
                                Console.WriteLine("enter user name");
                                n1 = Console.ReadLine();
                                Console.WriteLine("enter email ");
                                email1 = Console.ReadLine();
                                Console.WriteLine("enter password");
                                pd1 = Console.ReadLine();
                                Console.WriteLine("Enterr your address");
                                add1 = Console.ReadLine();
                                Console.WriteLine("enter 10 digit mobile number:");
                                mob1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter the company name:");
                                co = Console.ReadLine();
                                s1.CreateSeller(n1, email1, pd1, add1, mob1, co);
                                Console.WriteLine("the elements are saved:");

                                break;
                            case 2:
                                Console.WriteLine("Enter username: ");
                                string bid1 = (Console.ReadLine());
                                Console.WriteLine("enter password:");
                                string Password1 = Console.ReadLine();

                                flag = s1.CheckSeller(bid1, Password1);
                                if (flag == true)
                                {
                                    Console.WriteLine("login Successful");
                                    while (true)
                                    {
                                        Console.WriteLine("1.Electronic 2.Homeappliances 3.Accessories ");
                                        Console.WriteLine("Menu \n 1:Add Prod \n 2:Display \n 3:Exit \n Enter your choice:");
                                        int ch3 = Convert.ToInt32(Console.ReadLine());
                                        if (ch3 == 1)
                                        {
                                            //Console.WriteLine("enter the no categories to add:");
                                            //int cat = Convert.ToInt32(Console.ReadLine());
                                            ////s1.additems();
                                            //for (int i = 0; i < cat; i++)
                                            //{

                                            Console.WriteLine("enter Category Name:");
                                            string Cna = Console.ReadLine();
                                            Console.WriteLine("enter Category id in num::");
                                            int Cid = Convert.ToInt32(Console.ReadLine());

                                            Console.WriteLine("Description of Category");
                                            string des = Console.ReadLine();
                                            Console.WriteLine("enter the sub_)category name:");
                                            string Subnmae = Console.ReadLine();
                                            Console.WriteLine("enter the Sub Categry id in num:");
                                            int sid = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("enter Item N0 in num:");
                                            int Ino = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("enter the item name:");
                                            string itname = Console.ReadLine();
                                            Console.WriteLine("enter the price of item:");
                                            int price = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("enter the item description:");
                                            string desit = Console.ReadLine();
                                            Console.WriteLine("no of stock:");
                                            int soc = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("remanrkjs");
                                            string re = Console.ReadLine();

                                            ibo.additems(Ino, price, itname, desit, soc, re, Cna, Cid, Subnmae, des, sid, bid1);

                                            //}
                                            //break;
                                        }
                                        else if (ch3 == 2)
                                            ibo.Display();
                                        else if (ch3 == 3)
                                            break;
                                        else
                                            Console.WriteLine("invalid");
                                        break;
                                    }
                                }

                                else
                                    Console.WriteLine("invalid credentials");
                                break;
                             
                        }
                        break;
                    case 4:
                        s1.DisplayItems();
                        break;
                }
            }
        }
    }
}
