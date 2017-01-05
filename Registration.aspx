<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="CAMS.Registration" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<script type="text/javascript" src="Scripts/jquery-3.1.1.min.js">
        $(document).ready(function () {
            $('.datepicker-field').datepicker();
        });
    </script>--%>
    <div class="form-horizontal">
        <h4>Create a new account</h4>
        <hr />
        <%--<asp:ValidationSummary runat="server" CssClass="text-danger" />--%>
        
       
        </div>
   
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="col-md-2 control-label">FirstName</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="FirstName" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="FirstNameFieldValidator" runat="server"  CssClass="text-danger" ControlToValidate="FirstName" ErrorMessage="FirstName is Required"></asp:RequiredFieldValidator>
                
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="MiddleName" CssClass="col-md-2 control-label">MiddleName</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="MiddleName" CssClass="form-control" TextMode="Email" />
                <br />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="LastName" CssClass="col-md-2 control-label">LastName</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="LastName" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LastNameRequiredFieldValidator" runat="server"  CssClass="text-danger" ControlToValidate="LastName" ErrorMessage="LastName is Required"></asp:RequiredFieldValidator>
                
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Phone" CssClass="col-md-2 control-label">Phone</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Phone" CssClass="form-control"  />
                
                <br />
                
            </div>
        </div>
    
        <div>
           
        </div>
            
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server"  Text="Register" CssClass="btn btn-default" ID="Register" OnClick="Register_Click"  />
                
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [UserName], [FirstName], [LastName], [MiddleName], [Email], [Phone], [Password], [ConfirmPassword] FROM [UserDetails]"></asp:SqlDataSource>
               
            </div>
        </div>
    <div>

    </div>

</asp:Content>
