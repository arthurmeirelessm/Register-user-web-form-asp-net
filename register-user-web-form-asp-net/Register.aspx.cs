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
            var newUser = new Models.Peoples();
            newUser.Name = nameId.Text;
            newUser.Email = emailId.Text;
            newUser.Number = numberId.Text;

            try
            {
                DAO.UserService.RegisterUser(newUser);
                registerMessage.Text = "Register with success";
            }
            catch (Exception ex)
            {
                registerMessage.Text = ex.Message;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}