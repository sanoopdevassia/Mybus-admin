<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="root_time.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 484px;
        }
        .style2
        {
            width: 484px;
            height: 44px;
        }
        .style3
        {
            height: 44px;
        }
        .style4
        {
            width: 484px;
            height: 36px;
        }
        .style5
        {
            height: 36px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="style2">
                Bus Root</td>
            <td class="style3">
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Stop</td>
            <td class="style5">
                <asp:TextBox ID="TextBox1" runat="server" Height="28px" Width="120px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
            </td>
        </tr>
    </table>
</asp:Content>

