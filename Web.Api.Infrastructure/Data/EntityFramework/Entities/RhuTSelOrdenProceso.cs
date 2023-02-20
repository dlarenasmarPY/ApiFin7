using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelOrdenProceso
{
    public decimal IdOrdenProceso { get; set; }

    public string DescripcionOrdProceso { get; set; } = null!;

    public DateTime FecOrdProceso { get; set; }

    public string TipoProceso { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short CgoCodCargo { get; set; }

    public short CantVacantesSol { get; set; }

    public short CantVacantesAsig { get; set; }

    public string CodEstadoOrdProceso { get; set; } = null!;

    public DateTime FecEstado { get; set; }

    public string SelOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParCargo CgoCodCargoNavigation { get; set; } = null!;

    public virtual ICollection<RhuTSelActividad> RhuTSelActividads { get; } = new List<RhuTSelActividad>();

    public virtual ICollection<RhuTSelPostulanteTemp> RhuTSelPostulanteTemps { get; } = new List<RhuTSelPostulanteTemp>();
}
