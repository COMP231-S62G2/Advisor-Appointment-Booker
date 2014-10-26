<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body background="App_Themes/all/cc.JPG">
    <form id="form1" runat="server">
    <h1 style="text-align:center; background-color:sandybrown">ADVISOR APPOINTMENT BOOKER</h1>
    <table width="100%" height="500px">
    <tr>
    <td valign="top" align="center">
    
    <h3><asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" 
                        BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                        Font-Size="1em" ForeColor="#333333" 
                        PasswordRecoveryText="Forgot Password?" 
                        PasswordRecoveryUrl="~/all/forgotpassword.aspx" 
            onloggedin="Login1_LoggedIn" Height="300px" Width="624px">
            <TextBoxStyle Font-Size="0.8em" />
            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
                BorderWidth="1px" Font-Names="Verdana" Font-Size="1em" ForeColor="#284775" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" 
                ForeColor="White" />
        </asp:Login>
        <br />
         Click <a href="all/register.aspx">here to register</a>
     </h3>
   
    
    </td>
   
    </tr>
    </table>
    </form>
</body>
</html>
