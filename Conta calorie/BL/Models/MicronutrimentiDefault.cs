using System;
using System.Collections.Generic;

namespace BL.Models;

public partial class MicronutrimentiDefault
{
    public int Id { get; set; }

    public int IdMicronutriente { get; set; }

    public int? Peso { get; set; }

    public int? Percentuale { get; set; }

    public bool? Perc { get; set; }

    public virtual Micronutrienti IdMicronutrienteNavigation { get; set; } = null!;
}
