using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nico01
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                txtConteo.Text = "0";
            
            }

        }
        protected void btnIncrementa_Click(object sender, EventArgs e) 
        {
            int conteo = Convert.ToInt32(txtConteo.Text) + 1;
            txtConteo.Text = conteo.ToString();
        }


    }
}