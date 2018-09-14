<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="convert.aspx.cs" Inherits="numbers.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 347px;
        }
        .auto-style3 {
            width: 347px;
            height: 42px;
        }
        .auto-style4 {
            height: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Number Converter<br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Convert from</td>
                    <td>
                        <asp:DropDownList ID="sourceList" runat="server" Width="323px" AutoPostBack="true" EnableViewState="true" OnSelectedIndexChanged="sourceList_SelectedIndexChanged">
                            <asp:ListItem Value="10">Decimal</asp:ListItem>
                            <asp:ListItem Value="16">Hexadecimal</asp:ListItem>
                            <asp:ListItem Value="8">Octal</asp:ListItem>
                            <asp:ListItem Value="2">Binary</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Conversion Source Value:</td>
                    <td>
                        <asp:TextBox ID="sourceNum" runat="server" Width="312px" OnTextChanged="sourceNum_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Convert to</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="resultList" runat="server" Width="323px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Result:</td>
                    <td>
                        <asp:Label ID="resultNum" runat="server" Text="Result Not Calculated"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="calculate_btn" runat="server" OnClick="calculate_btn_Click" Text="Calculate" Width="323px" />
                    </td>
                    <td>
                        <asp:Button ID="clear_btn" runat="server" OnClick="clear_btn_Click" Text="Clear" Width="323px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
