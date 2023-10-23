<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddRecipe.aspx.cs" Inherits="Food_recipe.Blogs" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="m-3 form-control w-75 mx-auto">
        <h2>Add Recipe</h2>
        <div class="form-group  ">
            <label for="blogtitle">Title</label>
            <input type="text" class="form-control" id="blogtitle" runat="server" placeholder="Enter Title">
        </div>
        <div class="form-group my-3">
            <label for="blogdescription">description</label>
            <asp:TextBox ID="blogdescription" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div>
            <label for="blogimage">Image</label>
            <input type="text" class="form-control" id="blogimage" runat="server" placeholder="Image URL">
        </div>

        <asp:Button ID="Button1" CssClass="btn w-100 btn-dark my-3"  runat="server" Text="Add" OnClick="blog_submit" />

    </div>
    <script src="/scripts/tinymce/tinymce.min.js"></script>
  <script>
      tinymce.init({
          selector: 'textarea',
          plugins: 'print preview powerpaste casechange importcss tinydrive searchreplace autolink autosave save directionality advcode visualblocks visualchars fullscreen image link media mediaembed template codesample table charmap hr pagebreak nonbreaking anchor toc insertdatetime advlist lists checklist wordcount tinymcespellchecker a11ychecker imagetools textpattern noneditable help formatpainter permanentpen pageembed charmap tinycomments mentions quickbars linkchecker emoticons advtable export',
          
          menubar: 'file edit view insert format tools table tc help',
          toolbar: 'undo redo | bold italic underline strikethrough | fontselect fontsizeselect formatselect | alignleft aligncenter alignright alignjustify | outdent indent |  numlist bullist checklist | forecolor backcolor casechange permanentpen formatpainter removeformat | pagebreak | charmap emoticons | fullscreen  preview save print | insertfile image media pageembed template link anchor codesample | a11ycheck ltr rtl | showcomments addcomment',

      });
  </script>
    

</asp:Content>
