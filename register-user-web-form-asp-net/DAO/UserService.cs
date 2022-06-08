using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace register_user_web_form_asp_net.DAO
{
    public class UserService
    {
        public static bool RegisterUser(Models.Users user)
        {
            try
            {
                using (var connection = new Models.Register_user_web_formEntities())
                {
                    connection.Users.Add(user);
                    connection.SaveChanges();
                    return true;
                }
            }
            catch (Exception error)
            {

                return false;
            }
        }
    }
}