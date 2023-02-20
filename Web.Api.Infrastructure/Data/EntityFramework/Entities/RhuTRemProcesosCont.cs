using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemProcesosCont
{
    public decimal ContProcId { get; set; }

    public decimal PProcRemId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public decimal PTipoOpeIdPago { get; set; }

    public decimal PConcRemIdMlqd { get; set; }

    public decimal PConcRemIdRju { get; set; }

    public decimal PConceptoCcpIdLqd { get; set; }

    public decimal PConceptoCcpIdRju { get; set; }

    public decimal PPerRemIdIni { get; set; }

    public decimal PPerRemIdTer { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PConceptoCcpIdLqdEsp { get; set; }

    public short TdoLqdEspId { get; set; }

    public virtual RhuTRemProceso PProcRem { get; set; } = null!;
}
