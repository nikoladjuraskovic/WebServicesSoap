<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebServicePage.aspx.cs" Inherits="TestWebService.WebServicePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />


    <asp:Panel ID="Panel1" runat="server" CssClass="form-group">

        <asp:Label ID="Label1" runat="server" Text="Enter First Number:" Font-Bold="true"></asp:Label>


        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>

    </asp:Panel>


    <asp:Panel ID="Panel2" runat="server" CssClass="form-group">

        <asp:Label ID="Label2" runat="server" Text="Enter Second Number:" Font-Bold="true"></asp:Label>


        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>

    </asp:Panel>

    <asp:Panel ID="Panel3" runat="server" CssClass="form-group">

        <asp:Label ID="Label3" runat="server" Text="Result:" Font-Bold="true"></asp:Label>


        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>

    </asp:Panel>

    <asp:Button ID="Button1" runat="server" Text="Show" CssClass="btn btn-primary" OnClick="Button1_Click" />

    <br />
    <br />

    <asp:GridView ID="GridViewCalculations" runat="server" CssClass="table" Width="50%" RowStyle-Font-Bold="true"></asp:GridView>


    <br />
    
    <asp:Button ID="Button2" runat="server" Text="Use Public Web Service" CssClass="btn btn-info" OnClick="Button2_Click" />

    <asp:Label ID="Label4" runat="server" Text="Result: " Font-Bold="true"></asp:Label>



</asp:Content>
