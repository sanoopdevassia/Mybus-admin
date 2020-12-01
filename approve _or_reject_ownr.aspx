<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="approve _or_reject_ownr.aspx.cs" Inherits="approve__or_reject_ownr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 22px;
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
                                <asp:BoundColumn DataField="ID" HeaderText="ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Name" HeaderText="Name"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Phone_Number" HeaderText="Phone Number">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="Gender" HeaderText="Gender"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Email_ID" HeaderText="Email ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Password" HeaderText="pass" Visible="False">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="Status" HeaderText="sta" Visible="False">
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
                        Owner ID</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Name</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Phone Number</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Gender</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        Email</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        Status</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Accept" onclick="Button1_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Reject" />
                    </td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</asp:Content>

