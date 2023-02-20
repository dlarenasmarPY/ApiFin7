using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTCcpCuotasMov
{
    public decimal POpeCcpId { get; set; }

    public string DetCcpOwner { get; set; } = null!;

    public int DetCcpNroCuota { get; set; }

    public int DetCcpNroLinea { get; set; }

    public int Periodo { get; set; }

    public short OpeCcpTotCuotas { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PConcRemId { get; set; }

    public decimal PDetCcpId { get; set; }

    public short DivCodigo { get; set; }

    public DateTime DetCcpFechaVenc { get; set; }

    public short ConCcpCod { get; set; }

    public string ConCcpGlosa { get; set; } = null!;

    public double DetCcpMontoLocalHaber { get; set; }

    public int CabOpeLinea { get; set; }
}
