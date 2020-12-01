<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Add_Bus.aspx.cs" Inherits="Add_Bus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style3
    {
        height: 52px;
    }
    .style12
    {
        height: 52px;
        width: 234px;
    }
        .style19
        {
            width: 234px;
            height: 34px;
        }
        .style21
        {
            height: 34px;
        }
        .style22
        {
            height: 38px;
            width: 234px;
        }
        .style24
        {
            height: 38px;
        }
        .style32
        {
            height: 34px;
            width: 143px;
            text-align: left;
        }
        .style33
        {
            height: 38px;
            width: 143px;
        }
        .style36
        {
            height: 52px;
            width: 143px;
        }
        .style38
        {
            width: 202px;
            height: 34px;
        }
        .style39
        {
            height: 38px;
            width: 202px;
        }
        .style42
        {
            height: 52px;
            width: 202px;
        }
        .style43
        {
            height: 48px;
            width: 234px;
        }
        .style44
        {
            height: 48px;
            width: 202px;
        }
        .style45
        {
            height: 48px;
            width: 143px;
        }
        .style46
        {
            height: 48px;
        }
        .style47
        {
            height: 53px;
            width: 234px;
        }
        .style48
        {
            height: 53px;
            width: 202px;
        }
        .style49
        {
            height: 53px;
            width: 143px;
        }
        .style50
        {
            height: 53px;
        }
        .style51
        {
            height: 49px;
            width: 234px;
        }
        .style52
        {
            height: 49px;
            width: 202px;
        }
        .style53
        {
            height: 49px;
            width: 143px;
        }
        .style54
        {
            height: 49px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
    <tr>
        <td class="style43">
            </td>
        <td class="style43">
            Bus Name</td>
        <td class="style44">
            <asp:TextBox ID="TextBox1" runat="server" Height="35px" Width="200px"></asp:TextBox>
        </td>
        <td class="style45">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="*" ControlToValidate="TextBox1" 
                ForeColor="Red" ></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="Name is invalid" ForeColor="Red" 
                ValidationExpression="[a-zA-Z]+$"></asp:RegularExpressionValidator>
        </td>
        <td class="style46">
            </td>
    </tr>
    <tr>
        <td class="style19">
            &nbsp;</td>
        <td class="style19">
            Bus Number</td>
        <td class="style38">
            <asp:TextBox ID="TextBox2" runat="server" Height="35px" Width="200px"></asp:TextBox>
        </td>
        <td class="style32">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td class="style21">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style22">
            &nbsp;</td>
        <td class="style22">
            Source</td>
        <td class="style39">
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                Height="30px" Width="200px">
                <asp:ListItem>select</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style33">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="DropDownList1" ErrorMessage="*" 
                ForeColor="Red" InitialValue="select"></asp:RequiredFieldValidator>
        </td>
        <td class="style24">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style22">
            </td>
        <td class="style22">
            Destination</td>
        <td class="style39">
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                Height="30px" Width="200px" 
                onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem>Select</asp:ListItem>
            </asp:DropDownList>
           
        </td>
        <td class="style33">
           
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="DropDownList2" ErrorMessage="*" 
                ForeColor="Red" InitialValue="select"></asp:RequiredFieldValidator>
           
        </td>
        <td class="style24">
           
            </td>
    </tr>
    <tr>
        <td class="style47">
            </td>
        <td class="style47">
            Root </td>
        <td class="style48">
            <asp:DropDownList ID="DropDownList3" runat="server" 
                onselectedindexchanged="DropDownList3_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td class="style49">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="TextBox5" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td class="style50">
            </td>
    </tr>
    <tr>
        <td class="style51">
            </td>
        <td class="style51">
            &nbsp;</td>
        <td class="style52">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" 
                Width="75px" style="height: 26px" class="btn btn-primary" />
        </td>
        <td class="style53">
            &nbsp;</td>
        <td class="style54">
            </td>
    </tr>
    <tr>
        <td class="style12">
            &nbsp;</td>
        <td class="style12">
            &nbsp;</td>
        <td class="style42">
            <asp:TextBox ID="TextBox5" runat="server" Height="35px" Width="200px" 
                ReadOnly="True" Visible="False">pending</asp:TextBox>
        </td>
        <td class="style36">
            &nbsp;</td>
        <td class="style3">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style12">
            &nbsp;</td>
        <td class="style12">
            &nbsp;</td>
        <td class="style42">
            <asp:TextBox ID="TextBox6" runat="server" ontextchanged="TextBox6_TextChanged" 
                Height="35px" Width="200px" ReadOnly="True" Visible="False">pending</asp:TextBox>
        </td>
        <td class="style36">
            &nbsp;</td>
        <td class="style3">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

