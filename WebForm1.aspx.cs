using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        

        //畫面讀取時的event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GridView1.DataSource = ConnectDB.ReadDroneDetail();
                this.GridView1.DataBind();
            }
            
        }

        //新增按鈕的event
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            //建立變數以接取TextBox的值
            int sid = Convert.ToInt32(this.TextDroneSid.Text);
            string name = this.TextDroneName.Text;
            string Manufacturer = this.TextManufacturer.Text;
            string WeightLoad = this.TextWeightLoad.Text;
            string Status = this.TextStatus.Text;
            string StopReason = this.TextStopReason.Text;
            string Operator = this.TextOperator.Text;


            //將變數傳進Method
            ConnectDB.InsertIntoDroneDetail(sid, name, Manufacturer, WeightLoad, Status, StopReason, Operator);

        }


        //刪除按鈕的event
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //建立變數以接取TextBox的值
            int sid = Convert.ToInt32(this.TextDroneSid.Text);

            //將變數傳進Method
            ConnectDB.DelectDroneDetail(sid);
        }


        //修改按鈕的event
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //建立變數以接取TextBox的值
            int sid = Convert.ToInt32(this.TextDroneSid.Text);
            string name = this.TextDroneName.Text;
            string Manufacturer = this.TextManufacturer.Text;
            string WeightLoad = this.TextWeightLoad.Text;
            string Status = this.TextStatus.Text;
            string StopReason = this.TextStopReason.Text;
            string Operator = this.TextOperator.Text;


            //將變數傳進Method
            ConnectDB.UpDateDroneDetail(sid, name, Manufacturer, WeightLoad, Status, StopReason, Operator);
        }


        //查詢電池資料表按鈕的event
        protected void ChangeBattery_Click(object sender, EventArgs e)
        {
            //網頁轉跳至DroneBattery.aspx
            Response.Redirect("DroneBattery.aspx");
        }


        //單筆查詢按鈕的event
        protected void SingleRead_Click(object sender, EventArgs e)
        {
            //建立變數以接取TextBox的值
            int sid = Convert.ToInt32(this.TextDroneSid.Text);

            //將變數傳進Method
            this.GridView1.DataSource = ConnectDB.ReadSingleDroneDetail(sid);

            //將回傳值放進GridView
            this.GridView1.DataBind();
        }


        //顯示全部按鈕的event
        protected void ReadAll_Click(object sender, EventArgs e)
        {
            this.GridView1.DataSource = ConnectDB.ReadDroneDetail();
            this.GridView1.DataBind();
        }
    }
}