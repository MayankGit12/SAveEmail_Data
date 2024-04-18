<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="testr.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 778px; margin-left: 161px;">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Enter Name:"></asp:Label>
       
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 35px" Width="318px"></asp:TextBox>
       
        <p>
            Enter phone<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 45px" Width="317px"></asp:TextBox>
        </p>
        <p>
&nbsp;Enter Address:&nbsp;<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 26px" Width="314px"></asp:TextBox>
        </p>
        <p>
            Current Location:
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 11px" Width="310px"></asp:TextBox>
        </p>
        <p>
            Attach Resume:<asp:FileUpload ID="FileUpload1" runat="server" style="margin-left: 28px" Width="339px" />
        </p>
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 141px" Text="Submit" Width="266px" />
    </form>
</body>
</html>
