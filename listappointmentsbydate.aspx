<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="listappointmentsbydate.aspx.cs" Inherits="listappointmentsbydate" Title="Appointment Date" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div style="height:509px; width: 100%;">
        <%= this.Scheduler.Render()%> // renders Scheduler to the page
     </div>	
</asp:Content>


