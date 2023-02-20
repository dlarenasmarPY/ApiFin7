using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcpTCompromiso
{
    public decimal OpeCcpId { get; set; }

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

    public DateTime OpeCcpPeriodoDesde { get; set; }

    public DateTime OpeCcpPeriodoHasta { get; set; }

    public byte OpeCcpEstado { get; set; }

    public DateTime CabOpePagFec { get; set; }

    public string OpeCcpOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<CcpTMovimiento> CcpTMovimientos { get; } = new List<CcpTMovimiento>();

    public virtual CcpTConceptosCcp PConceptoCcp { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;
}
