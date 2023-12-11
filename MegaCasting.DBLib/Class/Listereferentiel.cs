using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Listereferentiel
{
    public int Id { get; set; }

    public string TypesContrat { get; set; } = null!;

    public string DomainesMetier { get; set; } = null!;

    public string Metier { get; set; } = null!;
}
