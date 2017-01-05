<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster1.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="CAMS.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height:400px" >

        <h2>Make a Payment</h2>
        <asp:Table ID="Table1" runat="server" Height="140px" Width="571px">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="type" runat="server" Text="AmountToPay"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:RadioButton ID="AmountToPayRadioButton" runat="server" GroupName="PaymentType" />
                </asp:TableCell>
            </asp:TableRow>     
        <asp:TableRow>
            <asp:TableCell>
                
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" Text="Other Amount"></asp:Label>
                <asp:RadioButton ID="OtherAmountRadioButton" runat="server" GroupName="PaymentType"/>
                <asp:TextBox ID="OtherAmountTextBox" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>           
        <asp:TableRow>
             <asp:TableCell>
                 <B><u>Bank Details</u></B>
             </asp:TableCell>
                <asp:TableCell>
                    
                </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" Text="Account Nick Name"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="AccountNicknameTextBox" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>  
         <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" Text="Account Type"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RadioButton ID="CheckingsRadioButton" runat="server"  GroupName="BankType"/>Checkings
               <asp:RadioButton ID="SavingsRadioButton" runat="server" GroupName="BankType"/>Savings
            </asp:TableCell>
        </asp:TableRow>
            <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" Text="Name On Account"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="AccountNameTextBox" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>   

         <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" Text="Routing Number"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="RoutingTextBox" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" Text="Account Number"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="AccountNumberTextBox" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" Text="Re-enter Account Number"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="ReenterAccountNumberTextBox" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        
            <asp:TableRow>
                <asp:TableCell>
                    
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="BackButton" runat="server" Text="Back"  OnClick="BackButton_Click"/>
                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>
