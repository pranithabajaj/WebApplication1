<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="LoginChild1.aspx.cs" Inherits="WebApplication1.LoginChild1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Empid
            </td>
            <td>
                <asp:TextBox ID="txteid" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter empid" ControlToValidate="txteid" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Password
            </td>
            <td>
                <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter password" ControlToValidate="txtpwd" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
