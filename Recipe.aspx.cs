using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_recipe
{
    public partial class Blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            int id = int.Parse(Request.QueryString["id"]);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            using (con)
            {
                con.Open();
                string insertQuery = "select * from [Blogs] where [id]=@id";
                SqlCommand command = new SqlCommand(insertQuery, con);
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string title = reader["title"].ToString();
                    string image = reader["image"].ToString();
                    string desc = reader["description"].ToString();
                    string ownerid = reader["owner_id"].ToString();
                    
                    title1.InnerText = title;
                    description1.InnerHtml = desc;
                    Image1.ImageUrl = image;
                    HttpCookie logininfo = Request.Cookies["logininfo"];
                    if (logininfo != null)
                    {
                        if (logininfo["id"] == ownerid)
                        {
                            Button1.Visible = true;
                        }
                        else
                        {
                            Button1.Visible= false;
                        }

                    }
                    else
                    {
                         Button1.Visible= false;
                    }
                }
                else
                {
                    Response.Redirect("/");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            using (con)
            {
                con.Open();



                string insertQuery = "DELETE FROM [Blogs] WHERE [id]=@id ";
                SqlCommand command_in = new SqlCommand(insertQuery, con);
                command_in.Parameters.AddWithValue("@id", id);
                int rowsAffected = command_in.ExecuteNonQuery();

                Response.Redirect("/");

            }
        }
    }
}