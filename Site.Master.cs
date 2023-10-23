using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_recipe {
    public partial class Site : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            HttpCookie logininfo = Request.Cookies["logininfo"];
            if (logininfo != null) {
                loginnavbtn.Visible = false;
                signupbtn.Visible = false;
                logoutbtn.Visible = true;
            } else {
                loginnavbtn.Visible = true;
                signupbtn.Visible = true;
                logoutbtn.Visible = false;
            }
        }

        protected void logoutbtn_Click(object sender, EventArgs e) {
            HttpCookie logininfo = new HttpCookie("logininfo");
            logininfo.Expires = DateTime.Now.AddDays(-1); // Set the expiration date in the past
            Response.Cookies.Add(logininfo);
            Response.Redirect("/");
        }
    }
}