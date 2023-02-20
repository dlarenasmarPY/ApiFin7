using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTCentrosResp
{
    public decimal CreId { get; set; }

    public int CreCodigo { get; set; }

    public string CreNombre { get; set; } = null!;

    public string CreDescUsoCresp { get; set; } = null!;

    public decimal PEntId { get; set; }

    public DateTime CreFecVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public DateTime FecEstadoReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte CreRhuEus { get; set; }

    public virtual ICollection<AdqTRolUsuarioCentro> AdqTRolUsuarioCentros { get; } = new List<AdqTRolUsuarioCentro>();

    public virtual ICollection<RhuTCapAgrupaDet> RhuTCapAgrupaDets { get; } = new List<RhuTCapAgrupaDet>();

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratos { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratos { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambios { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTParEstrOrganica> RhuTParEstrOrganicas { get; } = new List<RhuTParEstrOrganica>();
}
