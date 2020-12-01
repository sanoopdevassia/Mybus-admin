<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Addtime_admin.aspx.cs" Inherits="Addtime_admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="style1">
                Bus Number</td>
            <td class="style1">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="29px" 
                    AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                    >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Bus Stop</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" Height="29px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Time</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="30px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

