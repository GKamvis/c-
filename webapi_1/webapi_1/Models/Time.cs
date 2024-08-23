using System;
using System.Collections.Generic;

namespace webapi_1.Models;

public partial class Time
{
    public int Id { get; set; }

    public DateOnly? Giris { get; set; }

    public DateOnly? Cixis { get; set; }

    public int? Kart { get; set; }
}
