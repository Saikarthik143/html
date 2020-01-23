using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPro
{
    class items
    {
        int id;
        int cid;
        int price;
        string item_name;
        string description;
        int stock_number;
        string remarks;
        string sellerID;
       
        SubCategory subcategory;
        public items(int item_id, int price, string item_name, string description, int stock_number, string remarke,string  sid,SubCategory category)
        {
            this.Id = item_id;
            this.Price = price;
            this.Item_name = item_name;
            this.Description = description;
            this.Stock_number = stock_number;
            this.Remarks = remarke;
            this.sellerID = sid;
            this.subcategory = category;
        }
        public override string ToString()
        {
            return this.Id + " " + this.Item_name + " " + this.Price + " " + this.Description + " " + this.Stock_number + " " + this.Remarks;
        }

        public int Id { get => id; set => id = value; }
        public int Cid { get => cid; set => cid = value; }
        public int Price { get => price; set => price = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public string Description { get => description; set => description = value; }
        public int Stock_number { get => stock_number; set => stock_number = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        internal SubCategory Subcategory { get => subcategory; set => subcategory = value; }
    }
}
