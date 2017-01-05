<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForgotPassword1.aspx.cs" Inherits="CAMS.ForgotPassword1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height:400px" >
        <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Forgot Password</h1>
        <asp:Table ID="Table1" runat="server" Height="138px" Width="450px">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <div class="form-group">
            
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>
                </asp:TableCell></asp:TableRow></asp:Table><asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
    
    </div>

</asp:Content>
