<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Food_recipe.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
          <section class="">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card bg-dark text-white" style="border-radius: 1rem;">
          <div class="card-body p-5 text-center">

            <div class="mb-md-5 mt-md-4">

              <h2 class="fw-bold mb-2 text-uppercase">Login</h2>
                
                <asp:Label class=" text-center mb-2 text-danger" ID="errorlogin" runat="server" Text=""></asp:Label>
              <p class="text-white-50 mb-5">Please enter your login and password!</p>

              <div class="form-outline form-white mb-4">
                  <asp:TextBox ID="loginemail" runat="server" class="form-control form-control-lg"></asp:TextBox>
        
                <label class="form-label" for="loginemail">Email</label>
              </div>

              <div class="form-outline form-white mb-4">
                  <asp:TextBox ID="loginpassword" runat="server" class="form-control form-control-lg"></asp:TextBox>
              
                <label class="form-label" for="loginpassword">Password</label>
              </div>

              <p class="small mb-5 pb-lg-2"><a class="text-white-50" href="forgot">Forgot password?</a></p>
                <asp:Button ID="loginbtn" runat="server" Text="Login" class="btn btn-outline-light btn-lg px-5" OnClick="loginuser" />
           

            </div>

            <div>
              <p class="mb-0">Don't have an account? <a href="signup" class="text-white-50 fw-bold">Sign Up</a>
              </p>
            </div>

          </div>
        </div>
      </div>
    </div>
  </div>
</section>
</asp:Content>
