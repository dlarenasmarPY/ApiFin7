using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTAporte
{
    public decimal AfiAporteId { get; set; }

    public decimal PDatContId { get; set; }

    public int AfiFolio { get; set; }

    public string AfiGlosa { get; set; } = null!;

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public double AfiValorAdqui { get; set; }

    public decimal PEntId { get; set; }

    public decimal PMonedaId { get; set; }

    public double AfiValorCompra { get; set; }

    public byte AfiOrigenCompra { get; set; }

    public DateTime AfiFechaAdq { get; set; }

    public string AfiDctoLegal { get; set; } = null!;

    public byte AfiContabiliza { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public decimal PCabOpeId { get; set; }

    public DateTime CabOpeFechaRev { get; set; }

    public decimal PCabOpeIdRev { get; set; }

    public byte AfiTipoAdicion { get; set; }

    public double AfiValorAdicionHist { get; set; }

    public double AfiMontoCrFiscal { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public short EntSucNumero { get; set; }

    public decimal PCabLlgId { get; set; }

    public decimal POcCabId { get; set; }

    public short TdoId { get; set; }

    public decimal POpeLogtCabId { get; set; }

    public decimal POpeLogtDetId { get; set; }

    public string AfiNacImp { get; set; } = null!;
}
