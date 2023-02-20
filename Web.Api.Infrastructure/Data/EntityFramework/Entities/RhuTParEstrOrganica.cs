using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParEstrOrganica
{
    public decimal EsoId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short EsoNivelNodo { get; set; }

    public string EsoEstrNiveles { get; set; } = null!;

    public short EsoCodUnidad { get; set; }

    public string EsoDesUnidad { get; set; } = null!;

    public decimal? EsoRespUnidId { get; set; }

    public decimal? PCreId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ConTCentrosResp? PCre { get; set; }

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual ICollection<RhuTParUsuariosOrg> RhuTParUsuariosOrgs { get; } = new List<RhuTParUsuariosOrg>();
}
