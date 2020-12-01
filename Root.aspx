<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Root.aspx.cs" Inherits="Root" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
        .style2
        {
            width: 124px;
        }
        .style3
        {
            width: 235px;
        }
        .style4
        {
            width: 215px;
        }
        .style5
        {
            width: 124px;
            height: 46px;
        }
        .style6
        {
            width: 215px;
            height: 46px;
        }
        .style7
        {
            width: 235px;
            height: 46px;
        }
        .style8
        {
            height: 46px;
        }
        .style9
        {
            width: 124px;
            height: 48px;
        }
        .style10
        {
            width: 215px;
            height: 48px;
        }
        .style11
        {
            width: 235px;
            height: 48px;
        }
        .style12
        {
            height: 48px;
        }
        .style13
        {
            width: 124px;
            height: 41px;
        }
        .style14
        {
            width: 215px;
            height: 41px;
        }
        .style15
        {
            width: 235px;
            height: 41px;
        }
        .style16
        {
            height: 41px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
    <tr>
        <td class="style5">
            </td>
        <td class="style6">
            Name</td>
        <td class="style7">
            <asp:TextBox ID="TextBox4" runat="server" Height="36px" Width="199px"></asp:TextBox>
        </td>
        <td class="style8">
        </td>
        <td class="style8">
            </td>
    </tr>
    <tr>
        <td class="style5">
            </td>
        <td class="style6">
            Source</td>
        <td class="style7">
            <asp:TextBox ID="TextBox1" runat="server" Height="35px" Width="200px"></asp:TextBox>
        </td>
        <td class="style8">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td class="style8">
            </td>
    </tr>
    <tr>
        <td class="style9">
            </td>
        <td class="style10">
            Destination</td>
        <td class="style11">
            <asp:TextBox ID="TextBox2" runat="server" Width="200px" Height="35px"></asp:TextBox>
        </td>
        <td class="style12">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="TextBox2" ErrorMessage="*" 
                ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td class="style12">
            </td>
    </tr>
    <tr>
        <td class="style13">
            &nbsp;</td>
        <td class="style14">
            Stop</td>
        <td class="style15">
            <asp:TextBox ID="TextBox3" runat="server" Height="35px" Width="200px"></asp:TextBox>
        </td>
        <td class="style16">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td class="style16">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td class="style3">
            <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" 
                BackColor="#99CC00" Width="92px" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

