<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body background="../App_Themes/all/cc.JPG">
    <form id="form1" runat="server">
    <div>
    
        <h1 style="text-align:center; background-color:sandybrown">ADVISOR APPOINTMENT BOOKER</h1>
    </div>
   
    <center>
       
        <br />
        <br />
       
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BackColor="#FFFBD6" 
        BorderColor="#FFDFAD" BorderStyle="Solid" BorderWidth="1px" 
        ContinueDestinationPageUrl="~/login.aspx" Font-Names="Verdana" 
        Font-Size="2em" Height="300px" Width="550px">
        <SideBarStyle BackColor="#990000" Font-Size="0.9em" 
            VerticalAlign="Top" />
        <SideBarButtonStyle ForeColor="White" />
        <ContinueButtonStyle BackColor="White" BorderColor="#CC9966" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
            ForeColor="#990000" />
        <NavigationButtonStyle BackColor="White" BorderColor="#CC9966" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
            ForeColor="#990000" />
        <HeaderStyle BackColor="#FFCC66" BorderStyle="Solid" Font-Bold="True" 
            Font-Size="0.9em" ForeColor="#333333" HorizontalAlign="Center" 
            BorderColor="#FFFBD6" BorderWidth="2px" />
        <CreateUserButtonStyle BackColor="White" BorderColor="#CC9966" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
            ForeColor="#990000" />
        <TitleTextStyle BackColor="#990000" Font-Bold="True" ForeColor="White"/>
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server" />
            <asp:CompleteWizardStep runat="server" />
        </WizardSteps>
    </asp:CreateUserWizard></center>
    </form>
</body>
</html>
