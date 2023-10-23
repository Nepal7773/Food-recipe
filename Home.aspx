<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Food_recipe.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="m-5  row row-cols-lg-4 row-cols-md-3 row-cols-sm-2 row-cols-1 g-4">
        <asp:Repeater runat="server" ID="blogsList">
            <ItemTemplate>

                <div class="col">
                    <div class="card">
                        <img src=" <%#Eval("image")%>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"> <%#Eval("title")%></h5>
                            <a href="/recipe?id=<%#Eval("id")%>" >Read More</a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
