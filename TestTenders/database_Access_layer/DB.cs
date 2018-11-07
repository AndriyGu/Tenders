using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Linq;
using TestTenders.Models.dbdiag;

namespace TestTenders.database_Access_layer
{
    public class DB2
    {
        public void test()
        {
            DataContext db = new DataContext(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            var query = from tender in db.GetTable<TestTenders.Models.dbdiag.Tender>()
                        group tender by tender.CategoryID;
        }
    }

    public class DB
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        private DataSet queryData(string query)
        {
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }


        private static String joins = @"
                            left join Org on Tenders.OrgId=Org.Id
                            left join Category on Tenders.CategoryID=Category.Id
                            left join TypeTenders on Tenders.TypeID=TypeTenders.Id
                            left join Currency on Tenders.CurrencyID=Currency.Id
            ";
        private static String tables = "tenders.*, Org.OrgTender, TypeTenders.Type, Currency.Currency, Category.Category";
        private static String select = $"SELECT {tables} from Tenders";

        public Tuple<int, DataSet> showData(string search, int orgid, int typeid, string datefrom, string dateto,
                                            int pageid, int pagesz)
        {
            List<string> queryParams = new List<string>();

            if (search != "")
                queryParams.Add("((ObjTender LIKE N'%" + search + "%') OR (DeskTender LIKE N'%" + search + "%'))");

            if (orgid != -1)
                queryParams.Add("(OrgID = " + orgid + ")");

            if (typeid != -1)
                queryParams.Add("(TypeID = " + typeid + ")");

            if (datefrom != "")
                queryParams.Add("(StartDate >= '" + datefrom + "')");

            if (dateto != "")
                queryParams.Add("(EndDate <= '" + dateto + "')");

            String pages = $@"
                            order by tenders.Id
                            OFFSET { pageid * pagesz } ROWS FETCH NEXT { pagesz } ROWS ONLY
            ";

            string count  = "Select COUNT(*) from Tenders";
            String where = String.Join(" AND ", queryParams.ToArray());

            if (queryParams.Count == 0)
                return new Tuple<int, DataSet>((int)queryData(count).Tables[0].Rows[0].ItemArray[0], 
                    queryData(select + joins + pages));
            else
                return new Tuple<int, DataSet>((int)queryData(count + " WHERE " + where).Tables[0].Rows[0].ItemArray[0],
                    queryData(select + joins + " WHERE " + where + " " + pages));
        }

        public DataSet showDetailed(int id)
        {
            return queryData(select + joins + " WHERE Tenders.Id=" + id.ToString());
        }

        public DataSet showFilterORG()
        {
            return queryData("Select * from Org");
        }

        public DataSet ShowFilterTYPE()
        {
            return queryData("Select * from TypeTenders");
        }

        public DataSet ShowFilterDateSTART()
        {
            return queryData("Select DISTINCT StartDate  from Tenders" +
                             " ORDER By StartDate ASC");
        }

        public DataSet ShowFilterDateEND()
        {
            return queryData("Select DISTINCT EndDate  from Tenders" +
                             " ORDER By EndDate ASC");
        }

    }
}