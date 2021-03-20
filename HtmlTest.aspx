<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlTest.aspx.cs" Inherits="HomeWork2.HtmlTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1">
            <tr>
                <th>sid</th>
                <th>battery_Name</th>
                <th>status</th>
                <th>stopReason</th>
            </tr>

            <asp:Literal ID="LtTableContent" runat="server"></asp:Literal>
        </table>
    </form>
</body>
</html>
