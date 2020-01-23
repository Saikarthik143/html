using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPro
{
    class SubCategory:Category
    {
        int cid;
        int sub_id;
        string sub_name;
        string sub_det;
        public SubCategory( int cid,string sub_name,string c_name,string sub_det,int sub_id):base(cid,sub_name)
        {
            this.Cid = cid;
            this.sub_det = sub_det;
            this.Sub_name = sub_name;
            this.Sub_id = sub_id;
            this.Cat_name = c_name;
        }
        public override string ToString()
        {
            return this.Cid + " " + this.Sub_det + " " + this.Sub_name + " " + this.Sub_id + "" + this.Cat_name;
        }
        public int Cid { get => cid; set => cid = value; }
        public int Sub_id { get => sub_id; set => sub_id = value; }
        public string Sub_name { get => sub_name; set => sub_name = value; }
        public string Sub_det { get => sub_det; set => sub_det = value; }
    }

}
