using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DSDIndestructibles3.Web.forms.procesos
{
    public partial class EntregarKit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable personTable = new DataTable();
                personTable.Columns.Add(new DataColumn("Flag"));
                personTable.Columns.Add(new DataColumn("NroSolicitud"));
                personTable.Columns.Add(new DataColumn("FechaSolicitud"));
                personTable.Columns.Add(new DataColumn("Ruc"));
                personTable.Columns.Add(new DataColumn("RazonSocial"));

                DataRow row1 = personTable.NewRow();
                row1["Flag"] = false;
                row1["NroSolicitud"] = "S00311241";
                row1["FechaSolicitud"] = "20/10/2015";
                row1["Ruc"] = "22010241321";
                row1["RazonSocial"] = "Ferretaria Pepito SA";
                personTable.Rows.Add(row1);

                DataRow row2 = personTable.NewRow();
                row2["Flag"] = false;
                row2["NroSolicitud"] = "S00311241";
                row2["FechaSolicitud"] = "20/10/2015";
                row2["Ruc"] = "22010241321";
                row2["RazonSocial"] = "Ferretaria Pepito SA";
                personTable.Rows.Add(row2);

                DataRow row3 = personTable.NewRow();
                row3["Flag"] = false;
                row3["NroSolicitud"] = "S00311241";
                row3["FechaSolicitud"] = "20/10/2015";
                row3["Ruc"] = "22010241321";
                row3["RazonSocial"] = "Ferretaria Pepito SA";
                personTable.Rows.Add(row3);

                DataRow row4 = personTable.NewRow();
                row4["Flag"] = false;
                row4["NroSolicitud"] = "S00311241";
                row4["FechaSolicitud"] = "20/10/2015";
                row4["Ruc"] = "22010241321";
                row4["RazonSocial"] = "Ferretaria Pepito SA";
                personTable.Rows.Add(row4);

                gvSolicitudes.DataSource = personTable;
                gvSolicitudes.DataBind();

            }
        }

        protected void gvSolicitudes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.Cells[0].GetType() == typeof(System.Web.UI.WebControls.DataControlFieldCell))
            {
                TableCell tc = e.Row.Cells[0];
                if (tc.Controls.Count > 0)
                {
                    CheckBox cb = (CheckBox)tc.Controls[0];
                    if (!(cb == null))
                    {
                        cb.Enabled = true;
                    }
                }
            }
        }
    }
}