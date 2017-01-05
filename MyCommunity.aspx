<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster1.Master" AutoEventWireup="true" CodeBehind="MyCommunity.aspx.cs" Inherits="CAMS.MyCommunity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/icon-calendar-128.png"/>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" PopupButtonID="ImageButton1">

    </ajaxToolkit:CalendarExtender>
</asp:Content>
