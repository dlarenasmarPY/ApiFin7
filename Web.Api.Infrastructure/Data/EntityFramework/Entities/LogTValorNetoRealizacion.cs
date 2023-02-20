using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTValorNetoRealizacion
{
    public decimal Vnrid { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public DateTime FechaProceso { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCctaId { get; set; }

    public double CostoPromMoneda { get; set; }

    public double ValorRealizacion { get; set; }

    public double DiferenciaCostoUniMoneda { get; set; }

    public double ValorTotalRebMoneda { get; set; }

    public double ValorTotalRevMoneda { get; set; }

    public double ValorAcumRebMoneda { get; set; }

    public double ValorAcumRevMoneda { get; set; }

    public byte ConEstCod { get; set; }
}
