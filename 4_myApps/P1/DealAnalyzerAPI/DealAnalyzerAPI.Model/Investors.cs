namespace DealAnalyzerAPI.Model
{
    public class Investors
    {
        // Fields
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Constructors

        public Investors() { }

        public Investors(int id, string username, string name, string email)
        {
            this.Id = id;
            this.Username = username;
            this.Name = name;
            this.Email = email;
        }

        // Methods

    }
}