<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Applications.aspx.cs" Inherits="CAMS.Applications" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div style="height:400px">
    <h3>
        Application Details
    </h3>
    <asp:Table ID="Table1" runat="server" Height="23px" Width="364px">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Apttype" runat="server" Text="Apartment Type"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ApartType" runat="server">
                    <asp:ListItem Value="2 Bed 2 Bath" Text="2 Bed 2 Bath"></asp:ListItem>
                    <asp:ListItem Value="2 Bed 1 Bath" Text="2 Bed 1 Bath"></asp:ListItem>
                    <asp:ListItem Value="1 Bed 1 Bath" Text="1 Bed 1 Bath"></asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="AvailableApartments" runat="server" Text="Block"></asp:Label>
            </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList ID="Block" runat="server" OnSelectedIndexChanged="Block_SelectedIndexChanged">
                        <asp:ListItem Value="1" Text="1">
                            
                        </asp:ListItem>
                        <asp:ListItem Value="1" Text="2">
                            
                        </asp:ListItem> 
                        <asp:ListItem Value="1" Text="3" >
                            
                        </asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>

            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Check_Availability" runat="server" Text="Check" OnClick="Check_Availability_Click"  />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label3" runat="server" Text="Available Apartments"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="AvailApartment" runat="server">
                    
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
            <asp:Label ID="Label1" runat="server" Text=" Application Status"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="status" runat="server" OnSelectedIndexChanged="status_SelectedIndexChanged" AutoPostBack="true"  >
        <asp:ListItem Value="Pending" Text ="Pending">
            
        </asp:ListItem>
        <asp:ListItem Value ="Approve" Text ="Approve">
            
        </asp:ListItem>
        
    </asp:DropDownList>
            </asp:TableCell>
            

        </asp:TableRow>
        
    </asp:Table>
    
    <br />
    

    <asp:GridView ID="Pending" runat="server" Height="168px" Width="579px" CellPadding="4" ForeColor="#333333" AutoGenerateColumns ="False" GridLines="None"  DataKeyNames="ApplicationId" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField AccessibleHeaderText="Select">
                <ItemTemplate>
                    <asp:CheckBox ID="Check" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ApplicationId" HeaderText="ApplicationId" SortExpression ="ApplicationId" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression ="Name" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression ="Email" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression ="Phone" />
            <asp:BoundField DataField="Apttype" HeaderText="Apartment type" SortExpression ="Apttype" HeaderStyle-Width="30px" />
            <asp:BoundField DataField="Rent" HeaderText="Rent" SortExpression ="Rent" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression ="Status" />
           
        </Columns>

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

    </asp:GridView>
    
</div>
    <asp:Button ID="Approve" runat="server" Text="Approve" OnClick="Approve_Click" />
    <asp:Button ID="Reject" runat="server" Text="Reject" OnClick="Reject_Click" />
    <asp:Button ID="Mail" runat="server" Text="Mail" OnClick="Mail_Click" />
</asp:Content>

