<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebRole1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="~/css/MainBoot.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>Enter User Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="202px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="327px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Init" Width="328px" />
                    </td>
                </tr>
            </table>
        </div>

    </form>
</body>
</html>
