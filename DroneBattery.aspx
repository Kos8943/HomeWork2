<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DroneBattery.aspx.cs" Inherits="HomeWork2.DroneBattery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <%-- 用<span>做出欄位標題,用TextBox做出輸入欄位,並給TextBox的ID命名,方便之後抓值 --%>
             <div><span>查詢號: </span><asp:TextBox ID="TextDroneBatterSid" runat="server"></asp:TextBox></div>
            <div><span>電池編號: </span><asp:TextBox ID="TextDroneBatteryName" runat="server"></asp:TextBox></div>
            <div><span>使用狀況: </span><asp:TextBox ID="TextBatteryStutas" runat="server"></asp:TextBox></div>
            <div><span>故障原因: </span><asp:TextBox ID="TextBatteryStopReason" runat="server"></asp:TextBox></div>


            <%-- 新增按鈕然後命名ID,並在設計分割頁點擊按鈕兩下,製作該按鈕的點擊事件(event). --%>
            <asp:Button ID="InserIntoBattery" runat="server" Text="新增" OnClick="InserIntoBattery_Click" />
            <asp:Button ID="UpdateBattery" runat="server" Text="修改" OnClick="UpdateBattery_Click" />
            <asp:Button ID="DelectBattery" runat="server" Text="刪除" OnClick="DelectBattery_Click" />
            <asp:Button ID="ReadSingle" runat="server" Text="單筆查詢" OnClick="ReadSingle_Click" />
            <asp:Button ID="ReadAll" runat="server" Text="顯示所有" OnClick="ReadAll_Click" />
            <asp:Button ID="TableChange" runat="server" Text="查詢無人機資料表" OnClick="ChangeTable" />
            <br />

            <%--用GridView來顯示資料表--%>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
