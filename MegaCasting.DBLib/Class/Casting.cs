using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Casting
{
    public int Id { get; set; }

    public string UrlCasting { get; set; } = null!;

    public string MailCasting { get; set; } = null!;

    public int TelCasting { get; set; }

    public int FaxCasting { get; set; }

    public string AdresseCasting { get; set; } = null!;
}
