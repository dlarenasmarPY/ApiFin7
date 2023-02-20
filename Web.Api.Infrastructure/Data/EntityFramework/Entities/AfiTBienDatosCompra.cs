using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTBienDatosCompra
{
    public decimal DatCompraId { get; set; }

    public decimal PCodigoBienId { get; set; }

    public decimal PCabLlgId { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PMonedaIdAdq { get; set; }

    public decimal POcCabId { get; set; }

    public int AfiCantidad { get; set; }

    public double AfiValorCompra { get; set; }

    public string AfiNacImp { get; set; } = null!;

    public DateTime AfiFechaAdq { get; set; }

    public short TdoId { get; set; }

    public string AfiDctoLegal { get; set; } = null!;

    public decimal POpeLogtCabId { get; set; }

    public decimal POpeLogtDetId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
