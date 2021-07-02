
namespace DiscussionDesktop.Model
{
    class User
    {
        public int Id { get; set; }
        public string Pseudo { get; set; }

        public User(int id, string pseudo)
        {
            Id = id;
            Pseudo = pseudo;
        }
    }
}
