using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTDevolucionDet
{
    public decimal DevolucionDetId { get; set; }

    public decimal PDevolucionCabId { get; set; }

    public byte TipoItem { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public double DpdCantidad { get; set; }

    public double PrecioUnitario { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public byte DldIndAfectoExento { get; set; }

    public decimal PDoctoLegalDetId { get; set; }

    public byte ConEstCod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal POpeLogtDetId { get; set; }

    public double CantidadStock { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public decimal PProductoKitId { get; set; }

    public decimal PDetReferenciaKitId { get; set; }

    public byte TseCodigo { get; set; }
}
