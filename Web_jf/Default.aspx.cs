using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_jf
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_web_Click(object sender, EventArgs e)
        {
           
           System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "_new", "window.open('https://app.youforever.online/','','toolbar=no,location=0,directories=0,status=0,menubar=0,scrollbars=1,resizable=1,fullscreen=yes');", true);
        }
    }
}