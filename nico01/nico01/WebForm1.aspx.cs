using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nico01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        /*
            ViewState: nos permite preservar los datos entre requests, el ViewState viaja con la pericion y la respuesta, 
            de esa manera se conserva el dato.
            Tenemos que colocar el nombre de la variable  para el ViewState. Si no se ha usado previamente tiene el valor de null
            Cuando lo leamos es importante hacer el typecast correspondiente.
        */
        private int conteo = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                txtConteo.Text = "0";
            
            }

        }
        protected void btnIncrementa_Click(object sender, EventArgs e) {
            //Si la variable click no es igual a null es que ya se uso la variable
            if (ViewState["click"]!=null) 
            {
                //Tomamos lo que tenemos en la variable click, le sumamos uno y lo almacenamos en "conteo" 
                conteo = (int)ViewState["click"] + 1;
            
            }
            //Guardamos en la variable 
            txtConteo.Text = conteo.ToString();
            ViewState["click"] = conteo;
        
        }
    }
}