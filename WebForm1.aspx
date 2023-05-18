<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Pekara.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label_naziv" runat="server" Text="Naziv peciva: "></asp:Label>
    <asp:TextBox ID="TextBox_naziv" runat="server"></asp:TextBox>
    <asp:Label ID="Label_cena" runat="server" Text="Cena peciva: "></asp:Label>
    <asp:TextBox ID="TextBox_cena" runat="server"></asp:TextBox>
    <asp:Label ID="Label_ukus" runat="server" Text="Ukus peciva: "></asp:Label>
    <asp:TextBox ID="TextBox_ukus" runat="server"></asp:TextBox>
    <asp:Label ID="Label_kolicina" runat="server" Text="Kolicina peciva: "></asp:Label>
    <asp:TextBox ID="TextBox_kolicina" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</asp:Content>
