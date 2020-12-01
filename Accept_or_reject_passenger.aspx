<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Accept_or_reject_passenger.aspx.cs" Inherits="Accept_or_reject_passenger" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:MultiView ID="MultiView1" runat="server">
    <asp:View ID="View1" runat="server">
        <table class="style1">
            <tr>
                <td>
                    <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False" 
                        onitemcommand="DataGrid1_ItemCommand" 
                        onselectedindexchanged="DataGrid1_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundColumn DataField="Name" HeaderText="Name"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Phone_Number" HeaderText="Phone Number">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="Email_ID" HeaderText="Email ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="ID" HeaderText="id" Visible="False">
                            </asp:BoundColumn>
                            <asp:ButtonColumn Text="view"></asp:ButtonColumn>
                        </Columns>
                    </asp:DataGrid>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <table class="style1">
            <tr>
                <td>
                    Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Phone Number</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Email</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Accept" onclick="Button1_Click" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Reject" onclick="Button2_Click" />
                </td>
            </tr>
        </table>
    </asp:View>
</asp:MultiView>
</asp:Content>

