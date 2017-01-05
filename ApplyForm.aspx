<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ApplyForm.aspx.cs" Inherits="WebApplication12345.ApplyForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Choose your Home</h1>
    <asp:MultiView ID="HomeType" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server" >
            <h1>Available Homes</h1>
            <style>
                .search-block 
                { border: 1px solid #CCC;
                    padding: 20px;
                    
                    }
                .custom-FilledAreaBorder {
    border: 1px solid #CCC;
}
.custom-FilledArea {
    background-color: #E7F8FC;
}
.Section{
    width:150px;
}
.table{
    align-content:center
}
            </style>
           <section class ="search-block custom-FilledArea custom-FilledAreaBorder">
            
            <h4>Available 1 Bed 1 Bath</h4>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/1 Bed 1 Bath.jpg" Height="86px" Width="160px" /> 
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:GridView ID="Availablehomes" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="Availablehomes_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
                    
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    <Columns>
                        <asp:CheckBoxField Text="Select" />
                        <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Select"  ControlStyle-BorderColor ="WindowText"  />
                        
                    </Columns>
                </asp:GridView>
                       
                    </asp:TableCell>
                </asp:TableRow>
             
                
            </asp:Table>
           </section>

        </asp:View>

    </asp:MultiView>
     <%--<asp:MultiView ID="Pictype" runat="server">
                                <asp:View ID="View2" runat="server">
                                     <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/1 Bed 1 Bath.jpg" Height="148px" />
                                </asp:View>
                                <asp:View ID="View1" runat="server">
                                    <asp:ImageButton ID="ImageButton2" runat="server"ImageUrl="~/Images/2%20Bed%201%20Bath.jpg"  />
                                </asp:View>
                                <asp:View ID="View3" runat="server">
                                    <asp:ImageButton ID="ImageButton3" runat="server"ImageUrl="~/Images/2%20Bed%202%20Bath.jpg"  />
                                </asp:View>
    </asp:MultiView>--%>
</asp:Content>
