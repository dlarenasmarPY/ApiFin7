using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcpTTmpCompromiso
{
    public string OwnerUser { get; set; } = null!;

    public string FldUserCode { get; set; } = null!;

    public decimal POpeCcpId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PConceptoCcpId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PCtoSecId { get; set; }

    public decimal PCtoTerId { get; set; }

    public DateTime OpeCcpFechaSol { get; set; }

    public int OpeCcpFolio { get; set; }

    public decimal OpeCcpMontoSolicitado { get; set; }

    public double OpeCcpMontoAprobado { get; set; }

    public decimal PMonedaId { get; set; }

    public short OpeCcpTotCuotas { get; set; }

    public DateTime OpeCcpFechaDescto { get; set; }

    public double OpeCcpTasa { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCreId { get; set; }

    public decimal PPartidaId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public DateTime OpeCcpPeriodoDesde { get; set; }

    public DateTime OpeCcpPeriodoHasta { get; set; }

    public byte OpeCcpEstado { get; set; }
}
