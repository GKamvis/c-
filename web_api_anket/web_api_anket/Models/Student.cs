using System;
using System.Collections.Generic;

namespace web_api_anket.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? StudentNumber { get; set; }



/*    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<Response> Responses { get; set; } = new List<Response>();

    public virtual ICollection<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();*/
}
