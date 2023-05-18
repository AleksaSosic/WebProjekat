using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pekara
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Pekara unos_pecivo = new Pekara();
            int rezultat;
            rezultat = unos_pecivo.Unos_Pecivo(TextBox_naziv.Text, TextBox_cena.Text, TextBox_ukus.Text, TextBox_kolicina.Text);
            if (rezultat == 0)
            {
                Response.Redirect("WebForm2.aspx");
            }
            else
            {
                TextBox_naziv.Text = "Поновите упис";
                TextBox_cena.Text = "Поновите упис";
                TextBox_ukus.Text = "Поновите упис";
                TextBox_kolicina.Text = "Поновите упис";
            }
        }
    }
}