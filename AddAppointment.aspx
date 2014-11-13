<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddAppointment.aspx.cs" Inherits="AddAppointment" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <h2> Add Appointment</h2>
    
    <table>
    <tr>
    <td style="height: 26px">
     Appointment Title : 
    </td>
    <td style="height: 26px; width: 261px">
        <asp:TextBox ID="txtTitle" runat="server"  size="30"></asp:TextBox>
    </td>
    </tr>
    
    <tr>
    <td>
     Appointment Text : 
    </td>
    <td style="width: 261px">
        <asp:TextBox ID="txtText" runat="server"  TextMode="MultiLine" Rows="5" Columns ="30"></asp:TextBox>
    </td>
    </tr>
    
         
    <tr>
    <td>
     <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>

     Appointment Date :  
    </td>
    <td style="width: 261px">
        <asp:TextBox ID="txtDate" runat="server"  size="10"></asp:TextBox> 
          <asp:Button ID="btndate" runat="server" Text="..."/>
            <cc1:CalendarExtender ID="Calendar1" PopupButtonID="btndate" runat="server" TargetControlID="txtDate"
                Format="MM/dd/yy">
            </cc1:CalendarExtender>
            
        
    </td>
    </tr>
    
    <tr>
    <td>
     Appointment  Time :  
    </td>
    <td style="width: 261px">
        <asp:TextBox ID="txtTime" runat="server"  size="10"></asp:TextBox> (HH24:MM)
    </td>
    </tr>
    
    <tr>
    <td>
     Notify Hours Before :  
    </td>
    <td style="width: 261px">
        <asp:TextBox ID="txtNHB" runat="server"  size="10"></asp:TextBox> 
    </td>
    </tr>
    
    <tr>
    <td>
     Select Department:  
    </td>
    <td style="width: 261px">
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem>School of Advancement</asp:ListItem>
            <asp:ListItem>School of Enginnering Technology and Science</asp:ListItem>
            <asp:ListItem>School of Communication</asp:ListItem>
            <asp:ListItem>School of Hospitality and Tourism</asp:ListItem>
            <asp:ListItem>School of Business</asp:ListItem>
        </asp:DropDownList>
        <br />
       
    </td>
    </tr>

     <tr>
    <td>
     Select Advisor:  
    </td>
    <td style="width: 261px">
        <asp:DropDownList ID="DropDownList2" runat="server">
           
            
        </asp:DropDownList>
        <br />
       
    </td>
    </tr>

    </table>
    
    <p />
        &nbsp;<p />
        &nbsp;<p />
    <asp:Button ID="btnAdd" runat="server" Text="Add Appointment" 
            onclick="btnAdd_Click" />
    <p style="height: 112px" />
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    
    <p style="height: 112px" />
        &nbsp;
    
    <script language="javascript" type="text/javascript">

    </script>
</asp:Content>

