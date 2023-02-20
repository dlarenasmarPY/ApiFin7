using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTDiferenciaDesglose
{
    public decimal DifDesId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short EjeAno { get; set; }

    public short PerId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public string DifDesOwner { get; set; } = null!;

    public double DifDesSaldoImpu { get; set; }

    public double DifDesSaldoLocal { get; set; }
}
