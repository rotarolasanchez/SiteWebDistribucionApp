using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace SiteWeb
{
    public class DBsql
    {
        protected SqlConnection cnx;

        public DBsql()
        {

        }

        public void Conectar()
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source = 192.168.254.6; Initial Catalog = DistribucionApp; user id = report; password = Report01";
            try
            {
                cnx.Open();
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message);
            }
        }

        public void Cerrar()
        {

        }




    }
}