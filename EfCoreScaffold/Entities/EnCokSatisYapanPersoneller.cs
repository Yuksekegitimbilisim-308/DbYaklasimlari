using System;
using System.Collections.Generic;

namespace EfCoreScaffold.Entities;

public partial class EnCokSatisYapanPersoneller
{
    public string Personel { get; set; } = null!;

    public int? SatışSayısı { get; set; }

    public int BirimPirimFiyatı { get; set; }

    public int? ÖdenecekPrimTutarı { get; set; }
}
