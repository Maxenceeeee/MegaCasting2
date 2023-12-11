using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class TypeContrat
{
    public int Id { get; set; }

    public DateTime TempsContrat { get; set; }

    public int SalaireContrat { get; set; }

    public string ConditionContrat { get; set; } = null!;
}
