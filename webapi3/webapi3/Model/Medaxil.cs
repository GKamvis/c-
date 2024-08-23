using System;
using System.Collections.Generic;

namespace webapi3.Model;

public partial class Medaxil
{
    public int Id { get; set; }

    public double? Miqdar { get; set; }

    public string? Aciqlama { get; set; }

    public DateTime? Tarix { get; set; }
}
