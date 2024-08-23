using System;
using System.Collections.Generic;

namespace web_api_anket.Models;

public partial class UserAccount
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? PasswordHash { get; set; }

    public int? StudentNumber { get; set; }

    public string? Email { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual Student? StudentNumberNavigation { get; set; }
}
