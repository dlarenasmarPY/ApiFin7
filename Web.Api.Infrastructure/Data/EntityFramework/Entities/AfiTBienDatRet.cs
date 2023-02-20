using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTBienDatRet
{
    public decimal DetRetId { get; set; }

    public decimal PDatContId { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public double AfiTasaRet { get; set; }

    public double AfiMontoRet { get; set; }

    public DateTime AfiFechaRet { get; set; }

    public double AfiValorAntesRet { get; set; }

    public double AfiValorDespRet { get; set; }

    public double AfiRetAcum { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public decimal PCabOpeId { get; set; }

    public byte AfiContabiliza { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
