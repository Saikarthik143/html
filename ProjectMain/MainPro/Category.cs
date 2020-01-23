using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPro
{
     class Category
    {
        int cat_id;
        string cat_name;

        public int Cat_id { get => cat_id; set => cat_id = value; }
        public string Cat_name { get => cat_name; set => cat_name = value; }
       // static List<Category> lcat = new List<Category>();
        public  Category(int cid, string name)
        {
            this.cat_id = cid;
            this.Cat_name = name;
          // lcat.Add(new Category(cid, name));

        }
    }
}
