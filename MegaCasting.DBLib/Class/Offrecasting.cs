using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Offrecasting
{
    public int Id { get; set; }

    public string Intitulé { get; set; } = null!;

    public int Référence { get; set; }

    public string DomaineMetier { get; set; } = null!;

    public string Métier { get; set; } = null!;

    public string TypeContrat { get; set; } = null!;

    public int NombrePoste { get; set; }

    public string Localisation { get; set; } = null!;

    public string DescriptionPoste { get; set; } = null!;

    public string DescriptionProfil { get; set; } = null!;

    public string Coordonnées { get; set; } = null!;
}
