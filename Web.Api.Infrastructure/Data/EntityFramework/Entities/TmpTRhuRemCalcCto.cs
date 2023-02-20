using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemCalcCto
{
    public decimal TmpCalcId { get; set; }

    public string CodOwner { get; set; } = null!;

    public int SecCalculo { get; set; }

    public short DivCodigo { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PProcRemPerId { get; set; }

    public short LiqSecRecalculo { get; set; }

    public decimal PLiqId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PAntPrevId { get; set; }

    public decimal PAntAfpId { get; set; }

    public decimal PAntSaludId { get; set; }

    public string? LqTestadoPago { get; set; }

    public string? LqTestadoCentraliz { get; set; }
}
