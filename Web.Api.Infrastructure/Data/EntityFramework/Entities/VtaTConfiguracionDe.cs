using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTConfiguracionDe
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public byte CfgVtaCodigoDescto { get; set; }

    public string CfgVtaGlosaDescto { get; set; } = null!;

    public double CfgVtaPorcDescto { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
