using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StatMtl
{
    public partial class enregistrement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = string.Format("Merci de votre réponse <br />" +
                "Prenom : {0}<br />" +
                "Nom : {1}<br />" +
                "Courriel : {2}<br />", 
                Request.Params["prenom"], 
                Request.Params["nom"],
                Request.Params["courriel"]);

            contenu.InnerHtml = result;
        }
    }
}