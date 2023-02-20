using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParLugarTrabajo
{
    public decimal LugId { get; set; }

    public short LugCodigo { get; set; }

    public string LugDescripcion { get; set; } = null!;

    public double LugPorZonaExtre { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratos { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratos { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambios { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTFlegFerRegional> RhuTFlegFerRegionals { get; } = new List<RhuTFlegFerRegional>();
}
