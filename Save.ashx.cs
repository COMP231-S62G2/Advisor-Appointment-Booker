using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DHTMLX.Common;
using DHTMLX.Helpers;
using System.Globalization;


    /// <summary>
    /// </summary>
    public class Save : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

           
            var action = new DataAction(context.Request.Form);
            var data = new DataClassesDataContext();

            try
            {

                var changedEvent = (appointment)DHXEventsHelper.Bind(typeof(appointment), context.Request.Form);//create event object from request

                switch (action.Type)
                {
                    case DataActionTypes.Insert: // define here your Insert logic
                        data.appointments.InsertOnSubmit(changedEvent);
                        
                        break;
                    case DataActionTypes.Delete: // define here your Delete logic
                        changedEvent = data.appointments.SingleOrDefault(ev => ev.appid == action.SourceId);
                     //   data.Events.DeleteOnSubmit(changedEvent);
                        break;
                    default:// "update" // define here your Update logic
                        var updated = data.appointments.SingleOrDefault(ev => ev.appid == action.SourceId);
                        //update "updated" object by changedEvent's values, 'id' should remain unchanged
                        DHXEventsHelper.Update(updated, changedEvent, new List<string>() { "id" });
                        break;
                }
                data.SubmitChanges();
                action.TargetId = changedEvent.appid;
            }
            catch
            {
                action.Type = DataActionTypes.Error;
            }

            context.Response.ContentType = "text/xml";
            context.Response.Write(new AjaxSaveResponse(action).ToString());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
