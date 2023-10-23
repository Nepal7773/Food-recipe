<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Food_recipe.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
   <section class="">
  <div class=" d-flex align-items-center ">
    <div class="container h-100">
      <div class="row d-flex justify-content-center align-items-center h-100">
        <div class="col-12 col-md-9 col-lg-7 col-xl-6">
          <div class="  my-2" style="border-radius: 15px;">
            <div class="card-body bg-gradient p-5">
              <h2 class="text-uppercase text-center mb-3">Create an account</h2>
              
                <asp:Label class=" text-center mb-2 text-danger" ID="errorsignup" runat="server" Text=""></asp:Label>
                <div class="form-outline mb-4">
                  <label class="form-label " for="signupname">Your Name</label>
                    
                <asp:TextBox ID="signupname" runat="server" class="form-control form-control-lg" ></asp:TextBox>
                </div>

                <div class="form-outline mb-4">
                  <label class="form-label " for="signupemail">Your Email</label>
                    
                <asp:TextBox ID="signupemail" runat="server" class="form-control form-control-lg" ></asp:TextBox>
                </div>

                <div class="form-outline mb-4">
                  <label class="form-label " for="signuppassword">Password</label>
                    
                <asp:TextBox ID="signuppassword" runat="server" class="form-control form-control-lg" ></asp:TextBox>
                </div>

                <div class="form-outline mb-4">
                  <label class="form-label  " for="repeatsignuppassword">Repeat your password</label>
                    
                <asp:TextBox ID="repeatsignuppassword" runat="server" class="form-control form-control-lg" ></asp:TextBox>
                 </div>

                <div class="form-check d-flex justify-content-center mb-5">
                  <input class="form-check-input me-2" type="checkbox" value="" name="signupcheckbox" id="signupcheckbox" />
                  <label class="form-check-label " for="signupcheckbox">
                    I agree all statements in <a href="/" class="text-body"><u>Terms of service</u></a>
                  </label>
                </div>

                <div class="d-flex justify-content-center">
                    <asp:Button ID="register" class="btn btn-success btn-block btn-lg gradient-custom-4 " runat="server" Text="Register" OnClick="Signupuser" />
 
                </div>

                <p class="text-center  mt-5 mb-0 ">Have already an account? <a href="login"
                    class="fw-bold "><u>Login here</u></a></p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
</asp:Content>
