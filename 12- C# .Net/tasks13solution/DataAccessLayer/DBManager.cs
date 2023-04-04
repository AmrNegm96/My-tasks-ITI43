using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Data;
using System.Configuration;
using System.Data.SqlTypes;


namespace DataAccessLayer
{


    public class DBManager
    {

        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter DAdapter;
        DataTable DTable;
        //SqlConnection sqlCN;
        //SqlCommand sqlCmdTitle;
        //SqlDataAdapter sqlDATitle;
        //DataTable DtTitle;

        //SqlCommand sqlCmdPublisher;
        //SqlDataAdapter sqlDAPublisher;
        //DataTable DtPublisher;

        public DBManager()
        {
            try
            {
                sqlCn = new SqlConnection(ConfigurationManager.ConnectionStrings["PubsCN"].ConnectionString);

                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = sqlCn;
                DAdapter = new(sqlCmd);
                DTable = new();
                //
                //SqlCommandBuilder sqlCmdBuilder = new SqlCommandBuilder(DAdapter);
                //DAdapter.DeleteCommand = sqlCmdBuilder.GetDeleteCommand();
            }
            catch
            {
                // Log Exception (when , where , what)
            }
        }

        #region for stored procedures that dont take parameters

        #region connected mode
        public int ExcuteNonQuery(string SPName)
        {
            try
            {
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SPName;
                if (sqlCn.State == ConnectionState.Closed)
                    sqlCn.Open();

                return sqlCmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally
            {
                sqlCn.Close();
            }

        }

        public int ExcuteNonQuery(string SPName, Dictionary<string, object> paramlst)
        {
            try
            {
                sqlCmd.Parameters.Clear();


                foreach (var item in paramlst)
                {
                    sqlCmd.Parameters.Add(new SqlParameter(item.Key, item.Value));

                }
                sqlCmd.CommandText = SPName;
                if (sqlCn.State == ConnectionState.Closed)
                    sqlCn.Open();

                return sqlCmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally
            {
                sqlCn.Close();
            }

        }
        public object ExcuteScalar(string SPName)
        {
            try
            {
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SPName;
                if (sqlCn.State == ConnectionState.Closed)
                    sqlCn.Open();

                return sqlCmd.ExecuteScalar();
            }
            catch
            {
                return new object();
            }
            finally
            {
                sqlCn.Close();
            }
        }
        #endregion

        #region disconnected mode
        public DataTable ExcuteDataTable(string SPName)
        {
            try
            {
                DTable.Clear();
                sqlCmd.Parameters.Clear();
                //clean data table and cmd from previous data
                sqlCmd.CommandText = SPName;
                DAdapter.Fill(DTable);
                return DTable;
            }
            catch
            {
                return new DataTable();
            }
        }

        #endregion

        #endregion

        //#region for stored procedures that take parameters

        //#region connected mode
        //public int ExcuteNonQuery(string SPName)
        //{
        //    try
        //    {
        //        sqlCmdTitle.Parameters.Clear();

        //        sqlCmdTitle.CommandText = SPName;
        //        if (sqlCN.State == ConnectionState.Closed)
        //            sqlCN.Open();

        //        return sqlCmdTitle.ExecuteNonQuery();
        //    }
        //    catch
        //    {
        //        return -1;
        //    }
        //    finally
        //    {
        //        sqlCN.Close();
        //    }

        //}
        //public object ExcuteScalar(string SPName)
        //{
        //    try
        //    {
        //        sqlCmdTitle.Parameters.Clear();

        //        sqlCmdTitle.CommandText = SPName;
        //        if (sqlCN.State == ConnectionState.Closed)
        //            sqlCN.Open();

        //        return sqlCmdTitle.ExecuteScalar();
        //    }
        //    catch
        //    {
        //        return new object();
        //    }
        //    finally
        //    {
        //        sqlCN.Close();
        //    }
        //}
        //#endregion

        //#region disconnected mode
        //public DataTable ExcuteDataTable(string SPName)
        //{
        //    try
        //    {
        //        DtTitle.Clear();
        //        sqlCmdTitle.Parameters.Clear();
        //        // clean data table and cmd from previous data

        //        sqlCmdTitle.CommandText = SPName;
        //        sqlDATitle.Fill(DtTitle);

        //        return DtTitle;
        //    }
        //    catch
        //    {
        //        return new DataTable();
        //    }
        //}

        //#endregion

        //#endregion
    }

}
