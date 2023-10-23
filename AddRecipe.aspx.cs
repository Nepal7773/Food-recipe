using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Food_recipe {

    
    public partial class Blogs : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

      

        protected void blog_submit(object sender, EventArgs e)
        {
            HttpCookie logininfo = Request.Cookies["logininfo"];
            if (logininfo == null)
            {
                Response.Redirect("/login");

            }

            string blogtitleText = blogtitle.Value;
            string blogdescText = blogdescription.Text;
            string imageurlText = blogimage.Value;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            
                using (con)
                {
                    con.Open();

                   

                    string insertQuery = "INSERT INTO [Blogs] (title, description, image,owner_id) VALUES (@title, @desc, @imageurl,@ownerid)";
                    SqlCommand command_in = new SqlCommand(insertQuery, con);
                    command_in.Parameters.AddWithValue("@title", blogtitleText);
                    command_in.Parameters.AddWithValue("@desc", blogdescText);
                    command_in.Parameters.AddWithValue("@imageurl", imageurlText);
                    command_in.Parameters.AddWithValue("@ownerid", logininfo["id"]);

                    int rowsAffected = command_in.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Response.Redirect("/");
                    }
                }

                con.Close();
            
            

        }
    }
}