using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace RecuperacionRegistros
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = "Data Source=dLAPTOP-LO8K6NU9\\SQLEXPRESS; "+"Initial Catalog = Northwind; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string selectSQL = "Select * from Products where CategoryID ='" + TextBox1.Text+"'";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                con.Close();
            }
            catch (Exception err)
            {

            }
            string selectSQL1 = "select * from Products ";
            SqlConnection con1 = new SqlConnection(connectionString);
            SqlCommand cmd1 = new SqlCommand(selectSQL1, con1);
            SqlDataReader dr1;
            try
            {
                con1.Open();
                dr1 = cmd1.ExecuteReader();
                GridView2.DataSource = dr1;
                GridView2.DataBind();
                con1.Close();
            }
            catch (Exception err)
            {

            }
        }
    }
}