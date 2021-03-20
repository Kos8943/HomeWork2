using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HomeWork2
{
    public partial class GridViewPage : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            DataTable dt = ConnectDB.ReadDroneBattery();

            this.Repeater1.DataSource = dt;
            this.Repeater1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Literal ltl = e.Item.FindControl("LtName") as Literal;

                if (ltl == null)
                    return;

                DataRowView drv = e.Item.DataItem as DataRowView;

                int? sidcol = drv.Row.Field<int?>("sid");

                if(sidcol.HasValue && sidcol.Value ==2)
                    ltl.Text = "Success!!";

            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string cmdName = e.CommandName;
            string cmdArgu = e.CommandArgument.ToString();

            if("DeleteItem" == cmdName)
            {
                ConnectDB.DelectBattery(Convert.ToInt32(cmdArgu));

                DataTable dt = ConnectDB.ReadDroneBattery();

                this.Repeater1.DataSource = dt;
                this.Repeater1.DataBind();
            }
        }
    }
}