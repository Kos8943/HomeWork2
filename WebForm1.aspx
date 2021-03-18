<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HomeWork2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- 用<span>做出欄位標題,用TextBox做出輸入欄位,並給TextBox的ID命名,方便之後抓值 --%>
            <div><span>查詢號: </span><asp:TextBox ID="TextDroneSid" runat="server"></asp:TextBox></div>
            <div><span>無人機編號: </span><asp:TextBox ID="TextDroneName" runat="server"></asp:TextBox></div>
            <div><span>製造商: </span><asp:TextBox ID="TextManufacturer" runat="server"></asp:TextBox></div>
            <div><span>起飛最大乘載重量: </span><asp:TextBox ID="TextWeightLoad" runat="server"></asp:TextBox></div>
            <div><span>使用狀態: </span><asp:TextBox ID="TextStatus" runat="server"></asp:TextBox></div>
            <div><span>停用原因: </span><asp:TextBox ID="TextStopReason" runat="server"></asp:TextBox></div>
            <div><span>負責人: </span><asp:TextBox ID="TextOperator" runat="server"></asp:TextBox></div>


            <%-- 新增按鈕然後命名ID,並在設計分割頁點擊按鈕兩下,製作該按鈕的點擊事件(event). --%>
            <asp:Button ID="btnCreate" runat="server" Text="新增" OnClick="btnCreate_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="修改" OnClick="btnUpdate_Click" />          
            <asp:Button ID="btnDelete" runat="server" Text="刪除" OnClick="btnDelete_Click" />
            <asp:Button ID="SingleRead" runat="server" Text="單筆查詢" OnClick="SingleRead_Click" />
            <asp:Button ID="ReadAll" runat="server" Text="顯示所有" OnClick="ReadAll_Click" />
            <asp:Button ID="ChangeBattery" runat="server" Text="查詢電池資料表" OnClick="ChangeBattery_Click" />

            <br />

            <%--用GridView來顯示資料表--%>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
