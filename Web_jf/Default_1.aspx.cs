using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_jf
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Imagebutton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.memoriafamiliar.online");
        }
    }
}