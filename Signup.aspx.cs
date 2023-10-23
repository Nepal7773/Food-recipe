using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_recipe {
    public partial class Signup : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            HttpCookie logininfo = Request.Cookies["logininfo"];
            if (logininfo != null) {
                Response.Redirect("/");
            }
        }

        protected void Signupuser(object sender, EventArgs e) {
            String name = signupname.Text.Trim();
            String email = signupemail.Text.Trim();
            String password = signuppassword.Text.Trim();
            String repeatpassword = repeatsignuppassword.Text.Trim();
            if(name == "" || email == "" || password == "" || repeatpassword == "") {
                errorsignup.Text = "Fill all information";
                return;
            } else {
                if(password != repeatpassword) {
                    errorsignup.Text = "Password not matching with confirm password!";
                    return;
                } else {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
                    try {
                        using (con) {
                            con.Open();
                            
                            string checkEmailQuery = "SELECT COUNT(*) FROM [User] WHERE Email = @Email";
                            using (SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, con)) {
                                checkEmailCmd.Parameters.AddWithValue("@Email", email);
                                int emailCount = (int)checkEmailCmd.ExecuteScalar();

                                if (emailCount > 0) {
                                    errorsignup.Text = "Email already exists. Please choose a different email.";
                                    return;
                                }
                            }

                            string insertQuery = "INSERT INTO [User] (Name, Email, Password) VALUES (@Name, @Email, @Password)";
                                SqlCommand command_in = new SqlCommand(insertQuery, con);
                                command_in.Parameters.AddWithValue("@Name", name);
                                command_in.Parameters.AddWithValue("@Email", email);
                                command_in.Parameters.AddWithValue("@Password", password);
                                int rowsAffected = command_in.ExecuteNonQuery();
                                if (rowsAffected > 0) {
                                    // User successfully inserted
                                    Response.Redirect("/login"); // Redirect to login page or another page as needed
                                } else {
                                    errorsignup.Text = "User registration failed.";
                                }
                            }
                        
                        con.Close();
                    }catch (Exception ex) {
                        errorsignup.Text = ex.Message;
                        con.Close();
                    }
                }
            }
        }
    }
}