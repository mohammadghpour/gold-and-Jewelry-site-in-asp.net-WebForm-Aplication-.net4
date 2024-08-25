using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        datacode datacode = new datacode();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (datacode.datareder(Textus.Text,Textpass.Text)==true) {
                Session["x1"] = "1";
                Response.Redirect("165643.aspx");
            }
            else
            {


                Labelwell.Visible = false;
                Labelerr.Visible = true;
            }

        }


    
    }
}