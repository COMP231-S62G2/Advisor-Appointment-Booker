using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using DHTMLX.Scheduler.Data;


    /// <summary>
    /// </summary>
    public class Data : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/json";// the data comes in JSON format
            context.Response.Write(
                new SchedulerAjaxData(new DataClassesDataContext().appointments) //events for loading to scheduler
                );
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
