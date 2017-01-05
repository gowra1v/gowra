<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Application.aspx.cs" Inherits="WebApplication12345.Application" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 

    <div class="jumbotron">
        <h2>Choose Your Home</h2>
        <p class ="lead">Our spacious one and two bedroom apartment homes are thoughtfully designed with your comfort in mind and are appointed with the premium materials and finishes you deserve such as cathedral ceilings and fireplaces.</p>
    </div>
    <div>
       <h4> <asp:Label ID="Note" runat="server" Text="Label" CssClass="text-danger">Click on the Image to select Apartment Type</asp:Label></h4>
    </div>
     <div class="form-group">
        
            <asp:Label runat="server"  CssClass="col-md-2 control-label">Lease Start Date</asp:Label>
            <div class="col-md-10">
                <asp:Table runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:TextBox  ID="startDate" runat="server" CssClass="form-control"  /> 
                        </asp:TableCell><asp:TableCell>
                            <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" Width="30px"   ImageUrl="~/Images/icon-calendar-128.png" OnClick="ImageButton1_Click" />
                        </asp:TableCell></asp:TableRow><asp:TableRow>
                        <asp:TableCell>
                            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar>
                        </asp:TableCell></asp:TableRow></asp:Table><br />
                
            </div>
        </div>
    <div class="row">
        <div class="col-md-4">
             <ul>
               <li>
                   1 Bedroom & 1 Bathroom </li><li>
                   722-800Sqft </li></ul><asp:ImageButton ID="oneBedoneBath" runat="server" ImageUrl="Images/1%20Bed%201%20Bath.jpg" Height="161px" Width="180px" OnClick="oneBedoneBath_Click" />
        </div>
        <div class="col-md-4">
           <ul>
               <li>
                   2 Bedroom &  1 Bathroom </li><li>
                   750-850Sqft </li></ul><asp:ImageButton ID="twoBedoneBath" runat="server" ImageUrl="~/Images/2 Bed 1 Bath.jpg" Height="154px" Width="181px" OnClick="twoBedoneBath_Click"/>
        </div>
        <div class="col-md-4">
             <ul>
               <li>
                   2 Bedroom & 2 Bathroom </li><li>
                   800-950Sqft </li></ul><asp:ImageButton ID="twoBedBath" runat="server" ImageUrl="~/Images/2 Bed 2 Bath.jpg" Height="159px" Width="180px" OnClick="twoBedBath_Click" />
        </div>
    </div>
   <div>
       
   </div>
    
   <asp:MultiView ID="LeaseTerm" runat="server">

        <asp:View ID="onebedonebathterm" runat="server" >
            <div class="row">
            <div class="col-md-4" >
               <h2>Lease Term</h2><asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">

                    <asp:ListItem Value="Sixmonths1">$800.00/mo. for 6 Months</asp:ListItem><asp:ListItem Value="twelvemonths1">$750.00/mo. for 12 Months</asp:ListItem><asp:ListItem Value="oneyear1">$700.00/mo. for 24 Months</asp:ListItem></asp:RadioButtonList></div><div class="col-md-4">

            </div>
            <div class="col-md-4">

            </div>
                </div>
        </asp:View>
       <asp:View ID="twobedonebathterm" runat="server">
           
           <div class="row" style="align-content:center">
           <div class="col-md-4">

            </div>
            <div  "col-md-4">
                <h2>Lease Term</h2><asp:RadioButtonList ID="BathRadioButtonList" runat="server">
                    <asp:ListItem Value="sixmonths3">$850.00/mo. for 6 Months</asp:ListItem><asp:ListItem Value="twelvemonths3"> $800.00/mo. for 12 Months</asp:ListItem><asp:ListItem Value="oneyear3">$700.00/mo. for 24 Months</asp:ListItem></asp:RadioButtonList></div><div class="col-md-4">

            </div>
               </div>
        </asp:View>
       <asp:View ID="twobedtwobathterm" runat="server">
           <div class="row">
           <div class="col-md-4">

            </div>
           <div class="col-md-4">

            </div>
          
            <div "col-md-4">
                <h2>Lease Term</h2><asp:RadioButtonList ID="BedRadioButtonList" runat="server">
                    <asp:ListItem Value="Sixmonths1">$1000.00/mo. for 6 Months</asp:ListItem><asp:ListItem Value="twelvemonths2">$9500.00/mo. for 12 Months</asp:ListItem><asp:ListItem Value="oneyear2">$900.00/mo. for 24 Months</asp:ListItem></asp:RadioButtonList></div></div></asp:View></asp:MultiView><div>
         


         
     </div>
</asp:Content>
