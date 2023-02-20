using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TesTCtaCteBanFormato
{
    public decimal PCtaCteBcoId { get; set; }

    public byte TesFormatoCheque { get; set; }

    public string TesFormatoGlosa { get; set; } = null!;
}
