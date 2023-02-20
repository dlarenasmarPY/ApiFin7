using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTGruposContablesTipoOpe
{
    public decimal GrupoContTipoOpeId { get; set; }

    public decimal PGrupoContCuentaId { get; set; }

    public decimal PGrupoContId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public decimal PCtaId { get; set; }

    public byte OrigenCentroResp { get; set; }

    public byte OrigenConceptoImp { get; set; }

    public DateTime FechaVigencia { get; set; }

    public decimal PCtaIngresoId { get; set; }

    public decimal PCtaProvisionIngId { get; set; }

    public decimal PCtaProvisionCosId { get; set; }

    public virtual ExiTGruposContable PGrupoCont { get; set; } = null!;
}
