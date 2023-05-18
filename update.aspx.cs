using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pekara
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Pekara istina = new Pekara();
            int id_pecivo = Convert.ToInt32(Request.QueryString["id"]);

            Pekara izmena = new Pekara();
            string naziv = TextBox1.Text;
            int cena = Convert.ToInt32(TextBox2.Text);
            string ukus = TextBox3.Text;
            int kolicina = Convert.ToInt32(TextBox4.Text);
            int rezultat = izmena.Izmena_Pecivo(id_pecivo, naziv, cena, ukus, kolicina);
            TextBox1.Text = id_pecivo.ToString();
            if (rezultat == 0)
            {
                Response.Redirect("WebForm2.aspx");
            }
            else
            {
                Response.Redirect("greska.aspx");
            }
        }
    }
}