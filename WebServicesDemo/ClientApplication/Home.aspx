<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ClientApplication.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>First number</td>
                <td>
                    <asp:TextBox ID="txt_first" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Second number</td>
                <td>
                    <asp:TextBox ID="txt_second" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btn_Add" runat="server" Text="Add" OnClick="btn_Add_Click" />
                </td>
            </tr>
        </table>
        <div>
            <asp:Label ID="lbl_message" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
