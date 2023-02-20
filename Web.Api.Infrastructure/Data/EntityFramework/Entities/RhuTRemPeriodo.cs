using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemPeriodo
{
    public decimal PerRemId { get; set; }

    public decimal PEmpId { get; set; }

    public short PerId { get; set; }

    public short EjeAno { get; set; }

    public DateTime PrmFecApertura { get; set; }

    public DateTime PrmFecBloqueo { get; set; }

    public DateTime PrmFecCierre { get; set; }

    public short PrmEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual GlbTPeriodo GlbTPeriodo { get; set; } = null!;

    public virtual ICollection<RhuTExcFechasEve> RhuTExcFechasEves { get; } = new List<RhuTExcFechasEve>();

    public virtual ICollection<RhuTLicDetSubsidio> RhuTLicDetSubsidios { get; } = new List<RhuTLicDetSubsidio>();

    public virtual ICollection<RhuTRemProcesosPer> RhuTRemProcesosPers { get; } = new List<RhuTRemProcesosPer>();
}
