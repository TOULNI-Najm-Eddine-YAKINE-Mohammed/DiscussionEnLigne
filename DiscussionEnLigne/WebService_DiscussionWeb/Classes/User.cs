
namespace WebService_DiscussionWeb.Classes
{
    public class User
    {
        public string Pseudo { get; set; }

        public User(string pseudo)
        {
            Pseudo = pseudo;
        }

        public User()
        {
        }
    }
}