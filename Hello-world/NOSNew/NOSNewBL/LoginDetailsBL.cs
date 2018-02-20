using NOSNewDAL;
using NOSNewDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NOSNew
{
    public class LoginDetailsBL
    {
        public LoginDetailsDO GetLoginDetails(string UserName, string Password)
        {
            LoginDetailsDO obj = new LoginDetailsDO();
            LoginDetailsDAL objDAL = new LoginDetailsDAL();
            obj = objDAL.GetLoginDetails(UserName, Password);
            return obj;
        }
    }
}
