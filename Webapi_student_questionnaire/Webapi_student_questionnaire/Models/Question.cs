using System;
using System.Collections.Generic;

namespace Webapi_student_questionnaire.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public int? StudentNumber { get; set; }

    public string? QuestionText { get; set; }

    public virtual ICollection<Response> Responses { get; set; } = new List<Response>();

    public virtual Student? StudentNumberNavigation { get; set; }
}
