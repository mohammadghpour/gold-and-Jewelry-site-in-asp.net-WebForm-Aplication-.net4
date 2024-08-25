using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        datacode datacode = new datacode();
        protected void Page_Load(object sender, EventArgs e)
        {
          // rptCustomers.DataSource = datacode.show();
         //  rptCustomers.DataBind();
        }

        protected void btnsendcon_Click(object sender, EventArgs e)
        {
            datacode.insertmail(txtnamecon.Text, txtlastnamcon.Text, txtnumcon.Text, txtmescon.Text);
            txtnamecon.Text = "نام شما ارسال شد";
            txtlastnamcon.Text = "نام خوانوادگی تان ارسال شد";
            txtnumcon.Text = "شماره شما ارسال شد";
            txtmescon.Text = "پیام شما ارسال شد";
        }
    }
}