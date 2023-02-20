using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemProcPago
{
    public string CodOwner { get; set; } = null!;

    public decimal PLiqId { get; set; }

    public decimal LqDrefOrigenId { get; set; }

    public double Monto { get; set; }

    public string TipoImputacion { get; set; } = null!;

    public decimal PCtaId { get; set; }

    public decimal PItmTipEntOri { get; set; }

    public decimal PTprId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PCfiId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PLineaProdId { get; set; }

    public short TdoId { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PFormaPagoId { get; set; }
}
