using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HomeWork2
{
    public partial class HtmlTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = ConnectDB.ReadDroneBattery();

            string outputText = string.Empty;

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                string sid = dr["sid"].ToString();
                string battery_Name = dr["battery_Name"].ToString();
                string status = dr["status"].ToString();
                string stopReason = dr["stopReason"].ToString();

                outputText += "<tr>";

                //轉型
                //int numcoL1 = Convert.ToInt32(stopReason);
                //int numcol2 = dr.Field<int>("stopReason");
                //int? stop = dr.Field<int?>("stopReason");


                outputText += $"<td>{sid}</td>";
                outputText += $"<td>{battery_Name}</td>";
                outputText += $"<td>{status}</td>";
                //outputText += $"<td>{stopReason}</td>";
                if (!dr.IsNull("stopReason"))
                {
                    outputText += $"<td>{stopReason}</td>";
                }
                else
                {
                    outputText += $"<td>-</td>";
                }
                //outputText += $"<td>{stopReason}</td>";

                outputText += "</tr>";
            }

            this.LtTableContent.Text = outputText;


        }
    }
}