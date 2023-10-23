using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_recipe {
    public partial class Login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            HttpCookie logininfo = Request.Cookies["logininfo"];
            if (logininfo != null) {
                Response.Redirect("/");
            }
        }

        protected void loginuser(object sender, EventArgs e) {
            String email = loginemail.Text.Trim();
            String password = loginpassword.Text.Trim();
            if (email == "" || password == "") {
                errorlogin.Text = "Fill all information";
                return;
            } else {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
                try {
                    using (con) {
                        con.Open();

                        string checkEmailQuery = "SELECT * FROM [User] WHERE Email = @Email";
                        using (SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, con)) {
                            checkEmailCmd.Parameters.AddWithValue("@Email", email);
                            SqlDataReader reader = checkEmailCmd.ExecuteReader();
                            if (reader.Read()) {
                                string emailget = reader["email"].ToString();
                                string passwordget = reader["password"].ToString();
                                string name = reader["name"].ToString();
                                string id = reader["id"].ToString();
                                if (email == emailget && password == passwordget) {
                                    con.Close();
                                    HttpCookie logininfo = new HttpCookie("logininfo");
                                    logininfo["email"] = emailget;
                                    logininfo["id"] = id;
                                    logininfo["name"] = name;
                                    logininfo.Expires = DateTime.Now.AddDays(10);
                                    Response.Cookies.Add(logininfo);
                                    Response.RedirectPermanent("/");
                                    return;
                                } else {
                                    errorlogin.Text = "Invalid creadintials";
                                    con.Close();
                                    return;
                                }
                            } else {
                                errorlogin.Text = "User not exists.";
                                con.Close();
                                return;
                            }
                        }
                    }
                    
                } catch (Exception ex) {
                    errorlogin.Text = ex.Message;
                    con.Close();
                }
                }

            }
        }
    }
