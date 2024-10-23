
using System.ComponentModel.DataAnnotations;

namespace HelpPlatform.Web.Identity;
public class LoginRequest{
    public const string Route = "/Identity";
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
