using BusinessLogicLayer.Entity;
using BusinessLogicLayer.EntityList;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.EntityManager
{
    public class publisherManager
    {
        static DBManager managerPublisher = new();
        public static publisherList SelectAllPublishers()
        {
            try
            {
                return DataTableToPublisherList(managerPublisher.ExcuteDataTable("SelectAllPublishers"));
            }
            catch
            {
                return new publisherList();
            }
        }
        public static publisherList getPublishersNames()
        {
            try
            {
                return DataTableToPublisherList(managerPublisher.ExcuteDataTable("getPublishersNames"));
            }
            catch
            {
                return new publisherList();
            }
        }
        
        internal static publisherList DataTableToPublisherList(DataTable dt)
        {
            publisherList pubLst = new publisherList();
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    pubLst.Add(DataRowToPublishers(row));
                }
            }
            catch
            {
                //
            }
            return pubLst;
        }
        internal static Publisher DataRowToPublishers(DataRow Dr)
        {
            Publisher p = new Publisher();

            try
            {
                p.Pub_id = Dr["pub_id"]?.ToString() ?? "NA";
                p.Pub_name = Dr["pub_name"]?.ToString() ?? "NA";
                p.State = EntityState.UnChanged;
            }
            catch
            {
                //
            }

            return p;
        }

    }
}
