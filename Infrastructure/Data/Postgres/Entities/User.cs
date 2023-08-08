using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string SurName { get; set; } = default!;
    public string Gsm { get; set; }
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public UserType UserType { get; set; }

    public List<Followers?> Followers { get; set; }
    public List<Tweets?> Tweets { get; set; }
}

public enum UserType
{
    User,
    Admin
}