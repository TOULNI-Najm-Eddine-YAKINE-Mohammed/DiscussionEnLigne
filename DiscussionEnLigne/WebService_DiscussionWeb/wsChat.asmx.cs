using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService_DiscussionWeb.Classes;
using WebService_DiscussionWeb.Model;

namespace WebService_DiscussionWeb
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class wsChat : System.Web.Services.WebService
    {

        [WebMethod]
        public bool exist(string pseudo)
        {
            foreach (User usr in Utils.getConnectedUsers())
            {
                if (usr.Pseudo.Equals(pseudo))
                    return true;
            }
            return false;
        }

        [WebMethod]
        public void addUser(User u)
        {
            Utils.getConnectedUsers().Add(u);
        }

        [WebMethod]
        public List<User> getAllUsers()
        {
            return Utils.getConnectedUsers();
        }

        [WebMethod]
        public void dropUser(User u)
        {
            int i;
            for(i=0; i<Utils.getConnectedUsers().Count; i++)
            {
                if (Utils.getConnectedUsers().ElementAt(i).Pseudo == u.Pseudo)
                    break;
            }
            if(i>=0 && i< Utils.getConnectedUsers().Count)
                Utils.getConnectedUsers().RemoveAt(i);
        }
    }
}
