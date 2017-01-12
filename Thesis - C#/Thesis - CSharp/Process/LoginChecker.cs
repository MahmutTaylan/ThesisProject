using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Thesis___CSharp.Process
{
    class LoginChecker
    {
        public static User login(String username, String pass){
            User result = null;

            String SQL = "SELECT * FROM users WHERE username='" + username + "' AND password='" + pass + "'";
            DataTable dt = DBConnection.selectDB(SQL);
            if (dt != null) {
                result = new User(Convert.ToInt32(dt.Rows[0][0].ToString()), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
            }

            return result;
        }
    
    }
}
