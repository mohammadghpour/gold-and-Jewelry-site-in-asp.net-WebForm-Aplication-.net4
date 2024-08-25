using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        datacode datacode = new datacode();
       
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Session["x1"] == null)
              Response.Redirect("l.aspx");
            GridView1.DataSource = datacode.show();
            GridView1.DataBind();
            GridViewmail.DataSource = datacode.showmail();
            GridViewmail.DataBind();
            GridViewprod.DataSource = datacode.showproduct();
            GridViewprod.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(id.Text);
            datacode.Insert(a,Textonvan.Text, Textinsert.Text);
            GridView1.DataSource = datacode.show();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void edit_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(id.Text);
            datacode.update(a, Textonvan.Text, Textinsert.Text);
            GridView1.DataSource = datacode.show();
            GridView1.DataBind();

        }

        protected void delet_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(id.Text);
            datacode.delet(a);
            GridView1.DataSource = datacode.show();
            GridView1.DataBind();

        }

        protected void btnsubpro_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(txtproid.Text);
            datacode.insertproduct(a,txtpronam.Text,txtgimat.Text,txtproimage.Text);
            GridViewprod.DataSource = datacode.showproduct();
            GridViewprod.DataBind();
        }

        protected void btneditsub_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(txtproid.Text);
            datacode.updatepro(a, txtpronam.Text, txtgimat.Text, txtproimage.Text);
            GridViewprod.DataSource = datacode.showproduct();
            GridViewprod.DataBind();
        }

        protected void btnprodel_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(txtproid.Text);
            datacode.deletpro(a);
            GridViewprod.DataSource = datacode.showproduct();
            GridViewprod.DataBind();
        }
    }
}