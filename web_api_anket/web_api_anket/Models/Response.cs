using System;
using System.Collections.Generic;

namespace web_api_anket.Models;

public partial class Response
{
    public int ResponseId { get; set; }

    public int? QuestionId { get; set; }

    public int? StudentNumber { get; set; }

    public double? Score { get; set; }

    public virtual Question? Question { get; set; }

    //public virtual Student? StudentNumberNavigation { get; set; }


}
