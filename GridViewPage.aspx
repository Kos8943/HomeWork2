<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewPage.aspx.cs" Inherits="HomeWork2.GridViewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="sid" HeaderText="編號" />
                <asp:BoundField DataField="battery_Name" HeaderText="電池編號" />
                <asp:BoundField DataField="date" DataFormatString="{0:yyyy-MM-dd}" HeaderText="時間" />
            </Columns>
        </asp:GridView>

        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                ID: <%# Eval("sid") %> <br />
                Name: <%# Eval("battery_Name") %><br />
                birthday: <%# Eval("status") %><br />
                <asp:Literal runat="server"> - </asp:Literal>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Button" CommandName="DeleteItem" CommandArgument=' <%# Eval("sid") %>'/>
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
