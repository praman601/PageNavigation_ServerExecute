using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerExecute
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Collections.Specialized.NameValueCollection previousCollection = Request.Form;
            lblName.Text = previousCollection["txtName"];
            lblEmail.Text = previousCollection["txtEmail"];

            
        }
    }
}