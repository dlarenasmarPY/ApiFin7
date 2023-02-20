using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTCajaBcoRegenera
{
    public DateTime Fecha { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int InstCod { get; set; }

    public decimal PCtaCteBcoId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public DateTime FechaSaldo { get; set; }

    public decimal SdoMtoDebe { get; set; }

    public decimal SdoMtoHaber { get; set; }

    public double MontoDebe { get; set; }

    public double MontoHaber { get; set; }

    public string Descripcion { get; set; } = null!;
}
