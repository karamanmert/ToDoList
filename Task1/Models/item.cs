using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class item
    {
        public static int no = 0;
        public int id { get; set; }
        public String not { get; set; }
        public String tarih {get;set;}
        public item(String not,String tarih)
        {
            this.id = ++no;
            this.not = not;
            this.tarih = tarih;

        }
        public item()
        {

        }
    }
}