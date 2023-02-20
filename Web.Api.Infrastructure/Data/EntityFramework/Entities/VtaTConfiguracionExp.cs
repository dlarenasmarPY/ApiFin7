using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTConfiguracionExp
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public decimal CfgVtapServicioFleteId { get; set; }

    public decimal CfgVtapServicioSeguroId { get; set; }

    public decimal CfgVtapServicioOtroGastoId { get; set; }

    public decimal CfgVtapContraCtaFsoId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte CfgVtaUsaCorrelativoEmb { get; set; }

    public int CfgVtaCorrelativoEmb { get; set; }
}
