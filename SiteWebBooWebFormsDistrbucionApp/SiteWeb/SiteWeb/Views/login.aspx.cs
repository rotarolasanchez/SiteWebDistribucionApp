using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteWeb
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int numero;
            numero = 0;
            DataView dvSql = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);

            if (dvSql.Count > 0)
            {
                numero = 1;
            }
            if (numero == 1)
            {
                //Session["usuario"] = dvSql[0].DataView[0];
                Session["usuario"] = dvSql[0].Row[0];
                
                Response.Redirect("http://localhost:62423/Views/index.aspx");
                //Response.Redirect("~/index.aspx");
            }
        }
    }
}