using BusinessLogicLayer.Entity;
using BusinessLogicLayer.EntityList;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Entity;
using BusinessLogicLayer.EntityList;
using System.Diagnostics;

namespace BusinessLogicLayer.EntityManager
{
    public class TitleManager
    {
        static DBManager managerTitle = new();

        public static bool UpdateTitleNamebyTitleID(string title_id, string title)
        {
            try
            {
                Dictionary <string,object> paramDic = new Dictionary <string,object>() { ["@title_id"]= title_id , ["@title"]= title };    
                return managerTitle.ExcuteNonQuery("UpdateTitleNamebyTitleID" , paramDic) > 0;
            }
            catch
            {

            }
            return false;
        }
        public static bool DeleteTitle(string title_id)
        {
            try
            {
                Dictionary<string, object> paramDic = new Dictionary<string, object>() ;
                paramDic.Add("@title_id", title_id);
                return managerTitle.ExcuteNonQuery("DeleteTitle", paramDic) > 0;
            }
            catch
            {
                //
            }
            return false;
        }
        public static bool addNewTitle(string Title_id, string Title, string Type, string Pub_id)
        {
            try
            {
                Dictionary<string, object> paramDic = new Dictionary<string, object>();
                paramDic.Add("@ID", Title_id);
                paramDic.Add("@TITLE", Title);
                paramDic.Add("@TYPE", Type);
                paramDic.Add("@PubID", Pub_id);
                return managerTitle.ExcuteNonQuery("addNewTitle", paramDic) > 0;
            }
            catch
            {
                //
            }
            return false;
        }
        public static TitleList SelectAllTitles()
        {
            try
            {
                return DataTableToTitleList(managerTitle.ExcuteDataTable("SelectAllTitles"));
            }
            catch
            {
                return new TitleList();
            }
        }

        public static void DoActions(TitleList tltLst)
        {
            foreach (var t in tltLst)
            {
                //Trace.WriteLine(t.State);

                if (t.State == EntityState.Changed)
                {
                    UpdateTitleNamebyTitleID(t.Title_id.ToString(), t.Title.ToString());
                }
                //if (t.State == EntityState.Deleted)
                //{
                //    //DeleteTitle(t.Title_id.ToString());
                //}
                if (t.State == EntityState.Added)
                {
                    addNewTitle(t.Title_id.ToString(), t.Title.ToString() , t.Type.ToString() , t.Pub_id.ToString());
                }
            }
        }
        internal static TitleList DataTableToTitleList(DataTable dt)
        {
            TitleList titlesLst = new TitleList();
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    titlesLst.Add(DataRowToTitles(row));
                }
            }
            catch
            {
                //
            }
            return titlesLst;
        }

        internal static titles DataRowToTitles(DataRow Dr)
        {
            titles t = new titles();

            try
            {
                t.Title_id = Dr["title_id"]?.ToString() ?? "NA";

                t.Title = Dr["title"]?.ToString() ?? "NA";

                t.Type = Dr["type"]?.ToString() ?? "NA";

                t.Pub_id = Dr["pub_id"]?.ToString() ?? "NA";

                if (decimal.TryParse(Dr["price"]?.ToString() ?? "-1", out decimal TempDecimal))
                    t.Price = TempDecimal;

                if (decimal.TryParse(Dr["advance"]?.ToString() ?? "-1", out TempDecimal))
                    t.Advance = TempDecimal;

                if (int.TryParse(Dr["royalty"]?.ToString() ?? "-1", out int TempInt))
                    t.Royalty = TempInt;

                if (int.TryParse(Dr["ytd_sales"]?.ToString() ?? "-1", out TempInt))
                    t.Ytd_sales = TempInt;

                t.Notes = Dr["notes"]?.ToString() ?? "NA";

                if (DateTime.TryParse(Dr["pubdate"].ToString() ?? "-1", out DateTime TempDateTime))
                    t.Pubdate = TempDateTime;

                t.State = EntityState.UnChanged;

            }
            catch
            {

            }

            return t;
        }


    }
}
