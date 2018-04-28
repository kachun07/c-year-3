<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebRole1.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="~/css/Admin.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td rowspan="2">Seller Name:</td>
                    <td rowspan="2">
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                    <td rowspan="2">
                        &nbsp;</td>
                    <td>Login As:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="139px"></asp:TextBox>
                    </td>
                    <td><a href="index.aspx">Logout</a></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button4" runat="server" Text="&lt;- Prev" OnClick="Button4_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button6" runat="server" Text="Next -&gt;" OnClick="Button6_Click" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        Add Details Here:</td>
                    <td>
                        Update Details Here:</td>
                    <td colspan="3" rowspan="11"><asp:Image ID="Image1" runat="server" src="images/Random_Access_Memories.jpg" />
                    </td>
                </tr>
                <tr>
                    <td>ID:</td>
                    <td>
                        <asp:TextBox ID="TextBox20" runat="server" ></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Artist:</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Year:</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Format:</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Price:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Genre:</td>
                    <td>
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Bid:</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>Bidder:</td>
                    <td>
                        <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>Status:</td>
                    <td>
                        <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button7" runat="server" Text="Update" OnClick="Button7_Click" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td colspan="3">
                        <asp:Button ID="Button8" runat="server" Text="Sell To Buyer" OnClick="Button8_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button9" runat="server" Style="margin-right: 80px" Text="Delete" OnClick="Button9_Click" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td colspan="3">
                        <asp:Button ID="Button10" runat="server" Text="Add" OnClick="Button10_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
