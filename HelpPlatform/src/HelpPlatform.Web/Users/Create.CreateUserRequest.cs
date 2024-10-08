﻿using System.ComponentModel.DataAnnotations;

namespace HelpPlatform.Web.Users;

public class CreateUserRequest
{
    public const string Route = "/Users";
    
    [Required]
    public string? Name { get; set; }
    
    [Required]
    public string? Email { get; set; }
}
