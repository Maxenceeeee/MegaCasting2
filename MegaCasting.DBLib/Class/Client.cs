using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Client
{
    public int Id { get; set; }

    public string NomEntreprise { get; set; } = null!;

    public string AdresseEntreprise { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public int CodePostal { get; set; }

    public int NumeroTelephone { get; set; }

    public string AdresseMail { get; set; } = null!;

    public int SirenEntreprise { get; set; }

    public int SiretEntreprise { get; set; }
}
