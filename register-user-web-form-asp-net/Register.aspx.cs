using register_user_web_form_asp_net.DAO;
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
            btnRegisterUser.Click += btnRegisterUser_Click;
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            var newUser = new Models.Users();
            newUser.Name = nameId.Text;
            newUser.Email = emailId.Text;
            newUser.Number = numberId.Text;

            bool VerifyIfRegisterOrNo = DAO.UserService.RegisterUser(newUser);
            if (VerifyIfRegisterOrNo)
            {
                registerMessage.Text = "Register with success";
            }
            registerMessage.Text = "Not registered";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}