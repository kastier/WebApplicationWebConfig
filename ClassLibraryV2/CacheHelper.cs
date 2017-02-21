using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace ClassLibraryV2
{
    public class CacheHelper
    {
        public static string getTickekInfoFormCacheString(string ticketStr)
        {
            
            if (string.IsNullOrEmpty(ticketStr))
            {

                return "{\"Status\":1}";
            }
            else
            {
                try
                {
                    
                    var ticket = FormsAuthentication.Decrypt(ticketStr);
                    string userData = ticket.UserData;
                    string userShowName = userData.Substring(userData.IndexOf("ShowName") + 11, userData.LastIndexOf("}") - userData.IndexOf("ShowName") - 12);
                    return  $"{{ \"Status\":0,  \"UserSessionInfo\": {{\"UserName\" :\"{ticket.Name}\",\"UserShowName\" : \"{userShowName}\",\"AuthencatedTime\" : \"{ticket.Expiration}\"}}}}";
                    
                }
                catch (Exception exp)
                {
                    return "{\"Status\":1}";
                }

            }
        }
    }
}
