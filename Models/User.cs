using ValuObjectsWebApi.ValueObjects;

namespace ValuObjectsWebApi.Models
{
    public sealed class User
    {
        public User(FirstName firstName, string lastName, string email)
        {            
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public int Id { get; set; }
        public FirstName FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
