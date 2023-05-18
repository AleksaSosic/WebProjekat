<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Pekara.WebForm2" %>
<%@ Import Namespace = "System.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class = "table">
        <tr>
            <td>
                Peciva: 
            </td>
        </tr>
        <%
            Pekara.Pekara pecivo = new Pekara.Pekara();
            DataSet ds = new DataSet();
            ds = pecivo.Pecivo();
            Response.Write("<tbody>");
            //try
            //{
            for (int i=0; i< ds.Tables[0].Rows.Count;i++)
            {
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(ds.Tables[0].Rows[i]["naziv"] + " ");
                Response.Write(ds.Tables[0].Rows[i]["cena"] + " ");
                Response.Write(ds.Tables[0].Rows[i]["ukus"] + " ");
                Response.Write(ds.Tables[0].Rows[i]["kolicina"]);
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write("<a href=brisanje.aspx?naziv=" + ds.Tables[0].Rows[i]["naziv"] +">");
                Response.Write("Brisanje");
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write("<a href=update.aspx?id=" + ds.Tables[0].Rows[i]["id_pecivo"] +">");
                Response.Write("Izmena");
                Response.Write("</td>");
                Response.Write("</tr>");

                //Response.Write("<tr>");
                //Response.Write("<td>");
                //Response.Write(ds.Tables[0].Rows[i]["cena"]);
                //Response.Write("</td>");
                //Response.Write("<td>");
                //Response.Write("<a href=brisanjeaspx?id=" + ds.Tables[0].Rows[i]["cena"] +">");
                //Response.Write("Brisanje");
                //Response.Write("</td>");
                //Response.Write("<td>");
                //Response.Write("<a href=update.aspx?id=" + ds.Tables[0].Rows[i]["id_pecivo"] +">");
                //Response.Write("Izmena");
                //Response.Write("</td>");
                //Response.Write("</tr>");

                //Response.Write("<tr>");
                //Response.Write("<td>");
                //Response.Write(ds.Tables[0].Rows[i]["ukus"]);
                //Response.Write("</td>");
                //Response.Write("<td>");
                //Response.Write("<a href=brisanjeaspx?id=" + ds.Tables[0].Rows[i]["ukus"] +">");
                //Response.Write("Brisanje");
                //Response.Write("</td>");
                //Response.Write("<td>");
                //Response.Write("<a href=update.aspx?id=" + ds.Tables[0].Rows[i]["id_pecivo"] +">");
                //Response.Write("Izmena");
                //Response.Write("</td>");
                //Response.Write("</tr>");

                //Response.Write("<tr>");
                //Response.Write("<td>");
                //Response.Write(ds.Tables[0].Rows[i]["kolicina"]);
                //Response.Write("</td>");
                //Response.Write("<td>");
                //Response.Write("<a href=brisanjeaspx?id=" + ds.Tables[0].Rows[i]["kolicina"] +">");
                //Response.Write("Brisanje");
                //Response.Write("</td>");
                //Response.Write("<td>");
                //Response.Write("<a href=update.aspx?id=" + ds.Tables[0].Rows[i]["id_pecivo"] +">");
                //Response.Write("Izmena");
                //Response.Write("</td>");
                //Response.Write("</tr>");
            }
            //}
            //catch (Exception ex)
            //{
            //    Response.Write(ex.Message[404]);
            //}
            Response.Write("<tbody>");
        %>
    </table>
</asp:Content>
