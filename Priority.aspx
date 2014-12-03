<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Priority.aspx.cs" Inherits="Priority" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server">
    <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
   
    <input type="hidden" runat="server" id="TargetSlotHiddenField" />
    <telerik:RadAjaxManager runat="server" ID="RadAjaxManager1" EnableAJAX="true">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadScheduler1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadScheduler1"></telerik:AjaxUpdatedControl>
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadGrid1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1"></telerik:AjaxUpdatedControl>
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadSplitter runat="server" ID="RadSplitter1" Height="552px" Width="880px"
        CssClass="exampleContainer" Orientation="Horizontal" Skin="Metro">
        <telerik:RadPane runat="server" ID="TopPane" Height="400px" Scrolling="None">
            <telerik:RadScheduler ID="RadScheduler1" runat="server" Skin="Metro"
                Width="100%" RowHeaderWidth="52" OverflowBehavior="Auto" ShowFooter="false" DataSourceID="SchedulerDataSource"
                DataKeyField="AppointmentID" DataStartField="Start" DataEndField="End" DataSubjectField="Subject"
                CustomAttributeNames="Due, Priority" RowHeight="37px" OnAppointmentCommand="RadScheduler1_AppointmentCommand"
                OnAppointmentInsert="RadScheduler1_AppointmentInsert">
                <AdvancedForm Modal="true"></AdvancedForm>
                <AppointmentTemplate>
                    <%# Eval("Subject") %>
                    <asp:Button runat="server" ID="UnscheduleAppointment" CssClass="simpleButton" CommandName="Unschedule"
                        Text="&nbsp;" ToolTip="Unschedule this appointment"></asp:Button>
                </AppointmentTemplate>
                <TimeSlotContextMenuSettings EnableDefault="true"></TimeSlotContextMenuSettings>
                <AppointmentContextMenuSettings EnableDefault="true"></AppointmentContextMenuSettings>
            </telerik:RadScheduler>
        </telerik:RadPane>
        <telerik:RadSplitBar runat="Server" ID="RadSplitBar1">
        </telerik:RadSplitBar>
        <telerik:RadPane runat="server" ID="BottomPane">
            <div style="float: left; height: 100%; width: 55px; background: #E3EFFF; text-align: center;
                border-right: 1px solid #6593CF;">
                <img src="images/tasks.gif" alt="" /></div>
            <div style="margin-left: 56px; border: none;">
                <telerik:RadGrid runat="server" ID="RadGrid1" DataSourceID="GridDataSource" GridLines="None"
                    AutoGenerateColumns="False" OnRowDrop="RadGrid1_RowDrop" Skin="Metro" Style="border: none;
                    outline: 0" Height="100%" AllowAutomaticInserts="True" AllowAutomaticUpdates="true"
                    AllowAutomaticDeletes="true" ShowFooter="true" OnItemCreated="RadGrid1_ItemCreated"
                    OnItemCommand="RadGrid1_ItemCommand" AllowSorting="true">
                    <ClientSettings AllowRowsDragDrop="True">
                        <Selecting AllowRowSelect="True"></Selecting>
                        <ClientEvents OnRowDropping="rowDropping" OnRowDblClick="onRowDoubleClick"></ClientEvents>
                    </ClientSettings>
                    <MasterTableView DataKeyNames="AppointmentID" InsertItemDisplay="Bottom" EditMode="InPlace">
                        <SortExpressions>
                            <telerik:GridSortExpression FieldName="Due" SortOrder="Ascending"></telerik:GridSortExpression>
                        </SortExpressions>
                        <Columns>
                            <telerik:GridTemplateColumn DataField="Subject" HeaderText="Task">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label1" Text='<%# Bind("Subject") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:LinkButton Text="Add new task" CommandName="<%# RadGrid.InitInsertCommandName %>"
                                        runat="server" ID="LinkButton1"></asp:LinkButton>
                                </FooterTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="Server" ID="TextBox1" Text='<%# Bind("Subject") %>' Width="100%"></asp:TextBox>
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridDateTimeColumn DataField="Due" HeaderText="Due Date" DataFormatString="{0:d}"
                                HeaderStyle-Width="200px">
                            </telerik:GridDateTimeColumn>
                            <telerik:GridTemplateColumn DataField="Priority" HeaderText="Priority" HeaderStyle-Width="200px">
                                <ItemTemplate>
                                    <asp:Label runat="Server" ID="Label2" Text='<%#Bind("Priority") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadComboBox runat="server" ID="priorityComboBox" SelectedValue='<%#Bind("Priority") %>'
                                        Skin="Office2007" Width="80px">
                                        <Items>
                                            <telerik:RadComboBoxItem Text="High" Value="High"></telerik:RadComboBoxItem>
                                            <telerik:RadComboBoxItem Text="Medium" Value="Medium"></telerik:RadComboBoxItem>
                                            <telerik:RadComboBoxItem Text="Low" Value="Low"></telerik:RadComboBoxItem>
                                        </Items>
                                    </telerik:RadComboBox>
                                    <asp:LinkButton ID="btnUpdate" Text="Save" runat="server" CommandName='<%# (Container is GridDataInsertItem) ? RadGrid.PerformInsertCommandName : RadGrid.UpdateCommandName %>'></asp:LinkButton>
                                    <asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" CommandName='<%# RadGrid.CancelCommandName %>'></asp:LinkButton>
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridButtonColumn ConfirmText="Delete this Appointment?" ButtonType="ImageButton"
                                CommandName="Delete" Text="Delete" UniqueName="DeleteColumn">
                                <HeaderStyle Width="20px"></HeaderStyle>
                                <ItemStyle HorizontalAlign="Center" CssClass="MyImageButton"></ItemStyle>
                            </telerik:GridButtonColumn>
                        </Columns>
                    </MasterTableView>
                </telerik:RadGrid>
            </div>
        </telerik:RadPane>
    </telerik:RadSplitter>


    </form>

</asp:Content>