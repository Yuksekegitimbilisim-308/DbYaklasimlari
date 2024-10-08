using System;
using System.Collections.Generic;

namespace EfCoreScaffold.Entities;

public partial class VTeslimEdilmeyenSiparisler
{
    public string CompanyName { get; set; } = null!;

    public int? TeslimEdilmeyenKargoSayısı { get; set; }

    public int? CezaBedeli { get; set; }
}
