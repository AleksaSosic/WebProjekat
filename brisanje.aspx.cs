using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pekara
{
    public partial class brisanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Pekara istina = new Pekara();
            string pecivo = Request.QueryString["naziv"];
            Pekara bacanje = new Pekara();
            int rezultat = bacanje.Bacanje_Pecivo(pecivo);

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