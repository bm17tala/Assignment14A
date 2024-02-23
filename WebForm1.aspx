<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment_14A.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h1>T-Shirt Order Form</h1>
        </header>

        <section>
            <asp:CheckBoxList ID="chkSizeList" runat="server" Height="224px" Width="164px">
                <asp:ListItem>XSMALL</asp:ListItem>
                <asp:ListItem>S</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>L</asp:ListItem>
                <asp:ListItem>XL</asp:ListItem>
                <asp:ListItem>XXLarge</asp:ListItem>
            </asp:CheckBoxList>
        </section>

        <aside>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity:   "></asp:Label>
            <asp:TextBox ID="txtQuantityValue" runat="server"></asp:TextBox>
        </aside>

        <asp:Button ID="btnReviewOrder" runat="server" Text="Review Order" OnClick="btnReviewOrder_Click" />
        <asp:Button ID="btnClearItems" runat="server" OnClick="btnClearItems_Click" Text="Clear Items" />
        <asp:Button ID="btnHelp" runat="server" OnClick="btnHelp_Click" Text="Help" />
        <p>
            <asp:TextBox ID="txtOrderList" runat="server" Height="102px" ReadOnly="True" TextMode="MultiLine" Width="237px"></asp:TextBox>
        </p>

    </form>
</body>
</html>
