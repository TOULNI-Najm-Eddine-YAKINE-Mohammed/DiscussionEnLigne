using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_DiscussionWeb.Classes;

namespace WebService_DiscussionWeb.Model
{
    public class Utils
    {
        private static List<User> users = null;

        public static List<User> getConnectedUsers()
        {
            if (users == null)
                users = new List<User>();
            return users;
        }
    }
}