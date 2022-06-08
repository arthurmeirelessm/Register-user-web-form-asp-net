using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace register_user_web_form_asp_net.DAO
{
    public class UserService
    {
        public static bool RegisterUser(Models.Peoples user)
        {
            try
            {
                using (var connection = new Models.Register_user_web_formEntities1())
                {
                    connection.Peoples.Add(user);
                    connection.SaveChanges();
                    return true;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}