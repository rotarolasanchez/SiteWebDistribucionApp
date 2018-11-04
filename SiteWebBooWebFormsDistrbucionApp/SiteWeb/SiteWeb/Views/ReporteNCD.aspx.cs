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
    public partial class hoja_despacho : System.Web.UI.Page
    {
        public static List<IndicadorNC.Elementos> Indicadores = new List<IndicadorNC.Elementos>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            string company, fechaini, fechafin;
            company = "";
            //usuario = "";
            fechafin = "";
            fechafin = "";
            company = txtcompany.Text.ToString();
            //usuario = txtUsuario.Text.ToString();
            fechaini = txtfechaini.Text.ToString();
            fechafin = txtfechafin.Text.ToString();
            ObtenerIndicadorNivelCumplimiento(company, fechaini, fechafin);
            DataTable table = ConvertListToDataTable(Indicadores);

            ReportViewer1.Reset();

            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Content/Report/Report1.rdlc");
            ReportDataSource rds = new ReportDataSource("DataSet", table);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.DataBind();
            ReportViewer1.LocalReport.Refresh();



        }
        static DataTable ConvertListToDataTable(List<IndicadorNC.Elementos> list)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(IndicadorNC.Elementos));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (IndicadorNC.Elementos item in list)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public List<IndicadorNC.Elementos> ObtenerIndicadorNivelCumplimiento(String company, String fechainicio, String fechafin)
        {

            Indicadores.Clear();
            //var JSON = "";
            SqlCommand cmd;
            SqlConnection cn = Conexion.cnxdistribucion();

            //JavaScriptSerializer javaScripSerializer = new JavaScriptSerializer();
            try
            {
                cmd = new SqlCommand("USP_WS_Consulta_Nivel_Cumplimiento_Despacho_Jefatura_Totales", cn);
                cmd.Parameters.AddWithValue("@company", company);
                //cmd.Parameters.AddWithValue("@SalesRepCode", chofer);
                cmd.Parameters.AddWithValue("@Fechainicio", fechainicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechafin);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IndicadorNC.Elementos i = new IndicadorNC.Elementos()
                    {
                        Company = reader["Company"].ToString(),
                        //Codigo = reader["Codigo"].ToString(),
                        //FechaDespacho = reader["FechaDespacho"].ToString(),
                        //Day = reader["Day"].ToString(),
                        CodigoChofer = reader["CodigoChofer"].ToString(),
                        NombreChofer = reader["NombreChofer"].ToString(),
                        Entregado = Convert.ToInt32(reader["Entregado"].ToString()),
                        Reprogramado = Convert.ToInt32(reader["Reprogramado"].ToString()),
                        Anulado = Convert.ToInt32(reader["Anulado"].ToString()),
                        Programado = Convert.ToInt32(reader["Programado"].ToString()),
                        Total = Convert.ToInt32((reader["Total"])),
                        Indicador = Convert.ToDouble(reader["Entregado"]) / Convert.ToDouble((reader["Total"]))
                    };
                    Indicadores.Add(i);
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

            return Indicadores;

        }
    }
}