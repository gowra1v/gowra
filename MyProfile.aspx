<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster1.Master" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="CAMS.MyProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

    </div>
    <div>

    </div>
    <div>
         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label">UserName</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="UserName" runat="server"  CssClass="form-control" Enabled="False">Gowra1991</asp:TextBox>
               
                
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="col-md-2 control-label">FirstName</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="FirstName" runat="server" CssClass="form-control" Enabled="False">vamshidhar</asp:TextBox>
              
                
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="MiddleName" CssClass="col-md-2 control-label">MiddleName</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="MiddleName" CssClass="form-control"  Enabled="False" >reddy</asp:TextBox>
                <br />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="LastName" CssClass="col-md-2 control-label">LastName</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="LastName" runat="server" CssClass="form-control" Enabled="False">gowra</asp:TextBox>
               
                
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" Enabled="False" >gowra1v@cmich.edu</asp:TextBox>
               
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Phone" CssClass="col-md-2 control-label">Phone</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Phone" CssClass="form-control" Enabled="False"  >6096475141</asp:TextBox>
                
                <br />
                
            </div>
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Button ID="Edit" runat="server" CssClass="btn btn-default" Text="Edit" OnClick="Edit_Click" />    
                    <asp:Button ID="Save" runat="server" CssClass="btn btn-default" Text="Save" OnClick="Save_Click" Visible="False" Width="69px"  />    
                        </div>
                
            </div>
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                        </div>
                
            </div>
    </div>
    </div>
</asp:Content>
