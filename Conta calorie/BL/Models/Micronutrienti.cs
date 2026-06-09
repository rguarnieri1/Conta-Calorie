using System;
using System.Collections.Generic;

namespace BL.Models;

public partial class Micronutrienti
{
    public int Id { get; set; }

    public string Micronutrimenti { get; set; } = null!;

    public virtual ICollection<MicronutrimentiDefault> MicronutrimentiDefaults { get; set; } = new List<MicronutrimentiDefault>();
}
