using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemPreviText
{
    public string CodOwner { get; set; } = null!;

    public decimal PLiqId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public byte TipoRegistro { get; set; }

    public byte ClmIindAccesorio { get; set; }

    public string LineaInfPrev { get; set; } = null!;
}
