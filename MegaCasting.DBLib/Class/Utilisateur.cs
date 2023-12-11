using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Utilisateur
{
    public int Id { get; set; }

    public bool Admin { get; set; }

    public string Pseudo { get; set; } = null!;

    public string Mdp { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public int Tel { get; set; }
}
