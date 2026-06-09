using System;
using System.Collections.Generic;

namespace BL.Models;

public partial class Peso
{
    public int Id { get; set; }

    public double? PesoKg { get; set; }

    public double? Collo { get; set; }

    public double? Vita { get; set; }

    public double? Fianchi { get; set; }
}
