using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTProyCalBitacoraCab
{
    public decimal AfiProyCalCabId { get; set; }

    public string AfiCodigoReferencia { get; set; } = null!;

    public DateTime AfiFechaReferencia { get; set; }

    public string AfiGlosaReferencia { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short AfiGrupoCod { get; set; }

    public short AfiSubGrpCod { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

    public short EjeAnoDesde { get; set; }

    public byte PerMesDesde { get; set; }

    public short EjeAnoHasta { get; set; }

    public byte PerMesHasta { get; set; }

    public double AfiTasaDep { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
