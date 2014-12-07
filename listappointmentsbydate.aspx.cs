using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using DHTMLX.Scheduler;

public partial class listappointmentsbydate : System.Web.UI.Page
{
    public DHXScheduler Scheduler { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Scheduler = new DHXScheduler();

        Scheduler.InitialDate = new DateTime(2011, 11, 24);// the initial data of Scheduler

        Scheduler.Config.first_hour = 8;//the minimum value of the hour scale
        Scheduler.Config.last_hour = 19;//the maximum value of the hour scale
        
        Scheduler.Config.time_step = 30;//the scale interval for the time selector in the lightbox
        Scheduler.Config.limit_time_select = true;// sets the max and min values for the time selector in the lightbox to the values of the last_hour and first_hour options

        Scheduler.DataAction = this.ResolveUrl("~/Data.ashx");// the handler which defines loading data to Scheduler
        Scheduler.SaveAction = this.ResolveUrl("~/Save.ashx");// the handler which defines create/update/delete logic
        Scheduler.LoadData = true;
        Scheduler.EnableDataprocessor = true;
    }
   
}
