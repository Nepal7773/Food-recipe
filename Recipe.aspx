<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recipe.aspx.cs" Inherits="Food_recipe.Blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="w-50 mx-auto my-5">

        <asp:Image ID="Image1" CssClass="w-100" runat="server" />
        <div class="m-3 " >
            
            <h1 runat="server" id="title1">

            </h1>
        </div>
        <div class="border border-dark rounded p-3 ">
            <p runat="server" id="description1">

            </p>
        </div>
        
        <asp:Button ID="Button1" CssClass="btn btn-sm btn-danger my-3" runat="server" Text="Delete" OnClick="Button1_Click"  />
    </div>
    
</asp:Content>
