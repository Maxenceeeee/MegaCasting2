using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Pack
{
    public int Id { get; set; }

    public string TypePack { get; set; } = null!;

    public int PrixPack { get; set; }

    public TimeSpan TempsPack { get; set; }
}
