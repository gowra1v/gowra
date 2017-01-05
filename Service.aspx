<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster1.Master" AutoEventWireup="true" CodeBehind="Service.aspx.cs" Inherits="CAMS.ServiceRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <br />
   
    <asp:Button ID="Maintainence" runat="server" Text="Maintainence"  Height="60px" class="btn btn-primary btn-lg sharp" OnClick="Maintainence_Click"/>
    <asp:Button ID="Lease_Termination" runat="server" Text="Lease_Termination" Height="60px" class="btn btn-primary btn-lg sharp" OnClick="Lease_Termination_Click" />
    <asp:Button ID="Lease_Extenion" runat="server" Text="Lease_Extenion"  Height="60px" class="btn btn-primary btn-lg sharp" OnClick="Lease_Extenion_Click"/>
        <br />
    <br />
    <asp:MultiView ID="LeaseTerm" runat="server">
        <asp:View ID="Maintainance" runat="server">
            <div style="height:400px" >
        <h2>Submit a Service Request</h2>
        
        <asp:Table ID="Table1" runat="server" Height="140px" Width="709px">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="type" runat="server" Text="RequestType"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList ID="Servicetype" runat="server">
                        <asp:ListItem>
                            Doors and Locks
                        </asp:ListItem>
                        <asp:ListItem>
                            Appliance
                        </asp:ListItem>
                        <asp:ListItem>
                            Electrical and Lighting
                        </asp:ListItem>
                        <asp:ListItem>
                            General
                        </asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            
        <asp:TableRow>
            
            <asp:TableCell><asp:Label runat="server" Text="Please provide more detail, if needed"></asp:Label>

            </asp:TableCell>
            <asp:TableCell>
             <textarea id="detail"  name="detail" rows="2" cols="20"  runat="server"></textarea>

            </asp:TableCell>
        </asp:TableRow>
            
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
     </div>   
        </asp:View>
        <asp:View ID="Termination1" runat="server">
            <div style="height:400px" >
        <h2>Lease Termination</h2>&nbsp;<asp:Table ID="Table2" runat="server" Height="84px" Width="908px">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label1" runat="server" Text="Termination Date"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                         <div class="form-group">
        
          
            <div class="col-md-10">
                <asp:Table runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:TextBox  ID="startDate" runat="server" CssClass="form-control"  /> 
                        </asp:TableCell><asp:TableCell>
                            <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" Width="30px"   ImageUrl="~/Images/icon-calendar-128.png" OnClick="ImageButton1_Click"  />
                        </asp:TableCell></asp:TableRow><asp:TableRow>
                        <asp:TableCell>
                            <asp:Calendar ID="Calendar1" runat="server"  OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar>
                        </asp:TableCell></asp:TableRow></asp:Table><br />
                
            </div>
        </div>
                    </asp:TableCell>
                </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="Label3" runat="server" Text="Reason"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <textarea id="reason"  name="reason" rows="2" cols="20"  runat="server"></textarea>
                </asp:TableCell>
            </asp:TableRow>
            </asp:Table>
            
            
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            
           <asp:Button ID="Termination123" runat="server" Text="Submit"  Width="84px" OnClick="Termination_Click"  />
          </div>
        </asp:View>
        <asp:View ID="Extension" runat="server">
            <div style="height:400px" >
        <h2>Lease Extension </h2>
                <asp:Table ID="Table3" runat="server" Height="51px" Width="737px">  
                 <asp:TableRow>
                     <asp:TableCell>
                         <asp:Label ID="Label2" runat="server" Text="Select Term"></asp:Label>
                     </asp:TableCell>
                     <asp:TableCell>
              <asp:DropDownList ID="term" runat="server">
                <asp:ListItem Value="6" Text="6 Months"></asp:ListItem>
                <asp:ListItem Value="12" Text="12 Months"></asp:ListItem>
                <asp:ListItem Value="18" Text="18 Months"></asp:ListItem>
            </asp:DropDownList>
                     </asp:TableCell>
                 </asp:TableRow>   
           
                    </asp:Table>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="TermSubmit" runat="server" Text="Submit" OnClick="TermSubmit_Click" />
                </div>
        </asp:View>
        
        </asp:MultiView>

        
    
                
    
</asp:Content>
