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
        string advisor = DropDownList2.SelectedItem.Text;
        //string dept = lblSelectedText.Text;

        if ( nhb == "")
               nhb = "0";

        String res = AppointmentsDAL.AddAppointment
            (Session["username"].ToString(),
            txtTitle.Text,
            txtText.Text,
            txtDate.Text + " " + txtTime.Text,
            nhb, dept_select,advisor);

        if (res == null)
            lblMsg.Text = "Successfully Added Appointment!";
        else
            lblMsg.Text = "Error -> " + res;

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string dept = DropDownList1.SelectedItem.Text;

        if (dept == "School of Advancement")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Insert(0, " ");
            DropDownList2.Items.Insert(1, "Stan Cameron");
            DropDownList2.Items.Insert(2, "Khalid Ali");
            
        }
        
           

        else if (dept == "School of Enginnering Technology and Science")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Insert(0, " ");
            DropDownList2.Items.Insert(1, "Bhakti Banjara");
            DropDownList2.Items.Insert(2, "Lisa Harper");
            
        }

        else if (dept == "School of Communication")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Insert(0, " ");
            DropDownList2.Items.Insert(1, "Isabella Kates");
            DropDownList2.Items.Insert(2, "Pepi Lucas");
          
        }

        else if (dept == "School of Hospitality and Tourism")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Insert(0, " ");
            DropDownList2.Items.Insert(1, "Jared Purdy");
            DropDownList2.Items.Insert(2, "Bob Ritchie");
          
        }

        else if (dept == "School of Business")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Insert(0, " ");
            DropDownList2.Items.Insert(1, "Renee Sgroi");
            DropDownList2.Items.Insert(2, "Kisha McPherson");
           
        }
       
    }
}
