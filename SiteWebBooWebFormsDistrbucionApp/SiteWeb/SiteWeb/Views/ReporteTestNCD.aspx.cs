using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using Microsoft.Reporting.WebForms;
using System.ComponentModel;

namespace SiteWeb
{
    public partial class Reporte : System.Web.UI.Page
    {
        public static List<IndicadorNCD.Elementos> Indicadores3 = new List<IndicadorNCD.Elementos>();

        protected void Page_Load3(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void btnbuscar3_Click(object sender, EventArgs e)
        {
            ObtenerIndicadorNivelCumplimientoTest();
            DataTable table = ConvertListToDataTable3(Indicadores3);

            ReportViewer4.Reset();

            ReportViewer4.LocalReport.ReportPath = Server.MapPath("~/Content/Report/Report3.rdlc");
            ReportDataSource rds = new ReportDataSource("DataSet", table);
            ReportViewer4.LocalReport.DataSources.Clear();
            ReportViewer4.LocalReport.DataSources.Add(rds);
            ReportViewer4.DataBind();
            ReportViewer4.LocalReport.Refresh();



        }
        static DataTable ConvertListToDataTable3(List<IndicadorNCD.Elementos> list)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(IndicadorNCD.Elementos));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (IndicadorNCD.Elementos item in list)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public List<IndicadorNCD.Elementos> ObtenerIndicadorNivelCumplimientoTest()
        {
            
            Indicadores3.Clear();
            //var JSON = "";
            SqlCommand cmd;
            SqlConnection cn = Conexion.cnxdistribucion();

            //JavaScriptSerializer javaScripSerializer = new JavaScriptSerializer();
            try
            {
                cmd = new SqlCommand("USP_WS_Consulta_TestNCD", cn);
                //cmd.Parameters.AddWithValue("@company", company);
                ////cmd.Parameters.AddWithValue("@SalesRepCode", chofer);
                //cmd.Parameters.AddWithValue("@Fechainicio", fechainicio);
                //cmd.Parameters.AddWithValue("@FechaFin", fechafin);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IndicadorNCD.Elementos ii = new IndicadorNCD.Elementos()
                    {
                        Company = reader["Company"].ToString(),
                        FechaDespacho = reader["FechaDespacho"].ToString(),
                        Entregado = Convert.ToDouble(reader["Entregado"]),
                        Reprogramado = Convert.ToDouble(reader["Reprogramado"]),
                        Total = Convert.ToDouble((reader["Total"])),
                        Indicador = Convert.ToDouble(reader["Entregado"])/ Convert.ToDouble((reader["Total"]))
                    };
                    Indicadores3.Add(ii);
                }
            }


            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return Indicadores3;

        }
    }
}