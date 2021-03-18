using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class DroneBattery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataSource = ConnectDB.ReadDroneBattery();
            this.GridView1.DataBind();
        }

        protected void InserIntoBattery_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(this.TextDroneBatterSid.Text);
            string batteryName = this.TextDroneBatteryName.Text;
            string stutas = this.TextBatteryStutas.Text;
            string stopReason = this.TextBatteryStopReason.Text;

            ConnectDB.InsertIntoDroneBattery(sid, batteryName, stutas, stopReason);
        }

        protected void DelectBattery_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(this.TextDroneBatterSid.Text);

            ConnectDB.DelectBattery(sid);
        }

        protected void UpdateBattery_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(this.TextDroneBatterSid.Text);
            string batteryName = this.TextDroneBatteryName.Text;
            string stutas = this.TextBatteryStutas.Text;
            string stopReason = this.TextBatteryStopReason.Text;

            ConnectDB.UpDateBattery(sid, batteryName, stutas, stopReason);
        }

        protected void ChangeTable(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void ReadSingle_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(this.TextDroneBatterSid.Text);

            this.GridView1.DataSource = ConnectDB.ReadSingleBattery(sid);
            this.GridView1.DataBind();
        }

        protected void ReadAll_Click(object sender, EventArgs e)
        {
            this.GridView1.DataSource = ConnectDB.ReadDroneBattery();
            this.GridView1.DataBind();
        }
    }
}