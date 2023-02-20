using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParVigDatosLeg
{
    public decimal LegId { get; set; }

    public decimal PEmpId { get; set; }

    public DateTime LegFecVigencia { get; set; }

    public decimal LegMutualId { get; set; }

    public decimal LegCajaCompid { get; set; }

    public double LegTasaAdiAccidente { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParInstitucione LegCajaComp { get; set; } = null!;

    public virtual RhuTParInstitucione LegMutual { get; set; } = null!;

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;
}
