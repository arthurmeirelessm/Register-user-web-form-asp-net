using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace register_user_web_form_asp_net
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected override void OnInit(EventArgs e)
        {
            RegisterButtonId.Click += RegisterButtonId_Click;
        }


        void RegisterButtonId_Click(object )


        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}