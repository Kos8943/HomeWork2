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

        //畫面讀取時的event
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataSource = ConnectDB.ReadDroneBattery();
            this.GridView1.DataBind();
        }

        //新增按鈕的event
        protected void InserIntoBattery_Click(object sender, EventArgs e)
        {
            //建立變數以接取TextBox的值
            int sid = Convert.ToInt32(this.TextDroneBatterSid.Text);
            string batteryName = this.TextDroneBatteryName.Text;
            string stutas = this.TextBatteryStutas.Text;
            string stopReason = this.TextBatteryStopReason.Text;

            //將變數傳進Method
            ConnectDB.InsertIntoDroneBattery(sid, batteryName, stutas, stopReason);
        }

        //刪除按鈕的event
        protected void DelectBattery_Click(object sender, EventArgs e)
        {
            //建立變數以接取TextBox的值
            int sid = Convert.ToInt32(this.TextDroneBatterSid.Text);

            //將變數傳進Method
            ConnectDB.DelectBattery(sid);
        }

        //修改按鈕的event
        protected void UpdateBattery_Click(object sender, EventArgs e)
        {
            //建立變數以接取TextBox的值
            int sid = Convert.ToInt32(this.TextDroneBatterSid.Text);
            string batteryName = this.TextDroneBatteryName.Text;
            string stutas = this.TextBatteryStutas.Text;
            string stopReason = this.TextBatteryStopReason.Text;

            //將變數傳進Method
            ConnectDB.UpDateBattery(sid, batteryName, stutas, stopReason);
        }

        //查詢電池資料表按鈕的event
        protected void ChangeTable(object sender, EventArgs e)
        {
            //網頁轉跳至DroneBattery.aspx
            Response.Redirect("WebForm1.aspx");
        }

        //單筆查詢按鈕的event
        protected void ReadSingle_Click(object sender, EventArgs e)
        {
            //建立變數以接取TextBox的值
            int sid = Convert.ToInt32(this.TextDroneBatterSid.Text);

            //將變數傳進Method
            this.GridView1.DataSource = ConnectDB.ReadSingleBattery(sid);

            //將回傳值放進GridView
            this.GridView1.DataBind();
        }

        //顯示全部按鈕的event
        protected void ReadAll_Click(object sender, EventArgs e)
        {
            this.GridView1.DataSource = ConnectDB.ReadDroneBattery();
            this.GridView1.DataBind();
        }
    }
}