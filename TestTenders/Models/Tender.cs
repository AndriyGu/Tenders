using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTenders.Models
{
    public class Tender
    {
        public int Id { get; set; }
        public String ObjTender { get; set; }
        public String DeskTender { get; set; }
        public int OrgID { get; set; }
        public int TypeID { get; set; }
        public int CategoryID { get; set; }
        public decimal Budget { get; set; }
        public int CurrencyID { get; set; }
        public String StartDate { get; set; }
        public String EndDate { get; set; }
        public String PubDate { get; set; }
        public string Type { get; set; }
        public string OrgTender { get; set; }
        public string Currency { get; set; }
        public string Category { get; set; }
    }


}