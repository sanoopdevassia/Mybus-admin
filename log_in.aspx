<%@ Page Title="" Language="C#" MasterPageFile="~/login.master" AutoEventWireup="true" CodeFile="log_in.aspx.cs" Inherits="log_in" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        height: 35px;
    }
    .style3
    {
        height: 29px;
    }
    .style4
    {
        height: 34px;
    }
    .style5
    {
        height: 29px;
        width: 233px;
    }
    .style6
    {
        height: 35px;
        width: 233px;
    }
    .style7
    {
        height: 34px;
        width: 233px;
    }
    .style8
    {
        height: 29px;
        width: 229px;
    }
    .style9
    {
        height: 35px;
        width: 229px;
    }
    .style10
    {
        height: 34px;
        width: 229px;
    }
    .style11
    {
        height: 29px;
        width: 134px;
    }
    .style12
    {
        height: 35px;
        width: 134px;
    }
    .style13
    {
        height: 34px;
        width: 134px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style11">
            User Name</td>
        <td class="style8">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td class="style3">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td class="style12">
            Password</td>
        <td class="style9">
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td class="style2">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style7">
            &nbsp;</td>
        <td class="style13">
        </td>
        <td class="style10">
            <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" 
                Height="29px" Width="85px" class="btn btn-primary" BackColor="#999966"/>
        </td>
        <td class="style4">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

