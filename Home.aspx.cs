using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_recipe {
    public partial class Home : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            using (con)
            {
                con.Open();
                string insertQuery = "select * from [Blogs]";
                SqlCommand command = new SqlCommand(insertQuery, con);
                blogsList.DataSource = command.ExecuteReader();
                blogsList.DataBind();

            }
        }

        
    }
}