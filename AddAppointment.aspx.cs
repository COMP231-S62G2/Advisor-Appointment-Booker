using System;


public partial class AddAppointment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

 
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string nhb = txtNHB.Text;
        //Retrieve Selected Text from Dropdown
        string dept_select = DropDownList1.SelectedItem.Text;
        //string dept = lblSelectedText.Text;

        if ( nhb == "")
               nhb = "0";

        String res = AppointmentsDAL.AddAppointment
            (Session["username"].ToString(),
            txtTitle.Text,
            txtText.Text,
            txtDate.Text + " " + txtTime.Text,
            nhb, dept_select);

        if (res == null)
            lblMsg.Text = "Successfully Added Appointment!";
        else
            lblMsg.Text = "Error -> " + res;

    }
  
}
