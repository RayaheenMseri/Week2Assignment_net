using System.ComponentModel.DataAnnotations;

namespace AmazonOrderSystem.Models{
    public class User
    {
    public int UserID {get; set;}

    public required string Name {get; set;}

    public required string Email {get; set;}

    public required string Password {get; set;}
    }
}
