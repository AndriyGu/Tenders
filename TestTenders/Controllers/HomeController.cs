using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using TestTenders.Models;

namespace TestTenders.Controllers
{
    public class HomeController : Controller
    {
        database_Access_layer.DB dbLayer = new database_Access_layer.DB();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult getrecord(string search, int orgid, int typeid, string datefrom, string dateto, 
                                    int pageid, int pagesz)
        {
            var count_data = dbLayer.showData(search, orgid, typeid, datefrom, dateto, pageid, pagesz);
            int count = count_data.Item1;
            DataSet ds = count_data.Item2;
            List<Tender> tenders = new List<Tender>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                tenders.Add(new Tender
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    ObjTender = dr["ObjTender"].ToString().Trim(),
                    DeskTender = dr["DeskTender"].ToString().Trim(),
                    OrgID = Convert.ToInt32(dr["OrgID"]),
                    TypeID = Convert.ToInt32(dr["TypeID"]),
                    CategoryID = Convert.ToInt32(dr["CategoryID"]),
                    Budget = Convert.ToDecimal(dr["Budget"]),
                    CurrencyID = Convert.ToInt32(dr["CurrencyID"]),
                    StartDate = Convert.ToDateTime(dr["StartDate"]).ToString(),
                    EndDate = Convert.ToDateTime(dr["EndDate"]).ToString(),
                    PubDate = Convert.ToDateTime(dr["PubDate"]).ToString(),
                    Type = dr["Type"].ToString().Trim(),
                    OrgTender = dr["OrgTender"].ToString().Trim(),
                    Currency = dr["Currency"].ToString().Trim(),
                    Category = dr["Category"].ToString().Trim()
                });
            }

            object[] o = new object[] { count, tenders };
            return Json(o, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getdetailed(int id)
        {
            DataSet ds = dbLayer.showDetailed(id);
            List<Tender> tenders = new List<Tender>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                tenders.Add(new Tender
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    ObjTender = dr["ObjTender"].ToString().Trim(),
                    DeskTender = dr["DeskTender"].ToString().Trim(),
                    OrgID = Convert.ToInt32(dr["OrgID"]),
                    TypeID = Convert.ToInt32(dr["TypeID"]),
                    CategoryID = Convert.ToInt32(dr["CategoryID"]),
                    Budget = Convert.ToDecimal(dr["Budget"]),
                    CurrencyID = Convert.ToInt32(dr["CurrencyID"]),
                    StartDate = Convert.ToDateTime(dr["StartDate"]).ToString(),
                    EndDate = Convert.ToDateTime(dr["EndDate"]).ToString(),
                    PubDate = Convert.ToDateTime(dr["PubDate"]).ToString()
                });
            }

            return Json(tenders, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getorg()
        {
            DataSet ds = dbLayer.showFilterORG();
            List<Org> tenders = new List<Org>();

            tenders.Add(new Org
            {
                Id = -1,
                OrgTender = "",
            });

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                tenders.Add(new Org
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    OrgTender = dr["OrgTender"].ToString().Trim(),
                });
            }

            return Json(tenders, JsonRequestBehavior.AllowGet);
        }

        public JsonResult gettype()
        {
            DataSet ds = dbLayer.ShowFilterTYPE();
            List<TenderType> tenders = new List<TenderType>();
            tenders.Add(new TenderType
            {
                Id = -1,
                Type = "",
            });

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                tenders.Add(new TenderType
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Type = dr["Type"].ToString().Trim(),
                });
            }

            return Json(tenders, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getdatefrom()
        {
            DataSet ds = dbLayer.ShowFilterDateSTART();
            List<TendersDate> tenders = new List<TendersDate>();

            tenders.Add(new TendersDate
            {
                date = "",
            });
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                tenders.Add(new TendersDate
                {
                    date = Convert.ToDateTime(dr["StartDate"]).ToString(),
                });
            }

            return Json(tenders, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getdateto()
        {
            DataSet ds = dbLayer.ShowFilterDateEND();
            List<TendersDate> tenders = new List<TendersDate>();

            tenders.Add(new TendersDate
            {
                date = "",
            });
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                tenders.Add(new TendersDate
                {
                    date = Convert.ToDateTime(dr["EndDate"]).ToString(),
                });
            }

            return Json(tenders, JsonRequestBehavior.AllowGet);
        }
    }
}