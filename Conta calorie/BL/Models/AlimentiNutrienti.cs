using System;
using System.Collections.Generic;

namespace BL.Models;

public partial class AlimentiNutrienti
{
    public int Id { get; set; }

    public int? IdAlimento { get; set; }

    public int? IdMicronutriente { get; set; }
}
