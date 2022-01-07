namespace MyStore.Domain.Account.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool Verified { get; set; }
    public bool Active { get; set; }
    public DateTime dateTime { get; set; }
    public int Role { get; set; }
    public string VerificationCode { get; set; }
    public string ActivationCode { get; set; }
    public string AuthorizationCode { get; set; }
    public DateTime LastAuthorizationCodeRequest { get; set; }
}

