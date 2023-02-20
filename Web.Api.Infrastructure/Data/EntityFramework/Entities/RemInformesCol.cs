using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RemInformesCol
{
    public decimal InfColId { get; set; }

    public decimal PInfRemId { get; set; }

    public decimal PClmInfId { get; set; }

    public short InfCsecColumna { get; set; }

    public DateTime InfCfecIniVigencia { get; set; }

    public DateTime InfCfecTerVigencia { get; set; }

    public string InfCtituloCol { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
