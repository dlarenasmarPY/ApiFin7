using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuCtoDistrib
{
    public string CodOwner { get; set; } = null!;

    public decimal PCtoId { get; set; }

    public decimal PProcRemId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public short EntSucNumero { get; set; }

    public double DpaPorcentaje { get; set; }

    public decimal PFormaPagoId { get; set; }

    public double Monto { get; set; }
}
