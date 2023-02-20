using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTConvenioDet
{
    public decimal ConvenioDetId { get; set; }

    public decimal PConvenioCabId { get; set; }

    public int Linea { get; set; }

    public byte TipoItem { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PCategoriaId { get; set; }

    public decimal PLineaProdId { get; set; }

    public decimal PMarcaId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public short PlazoEntrega { get; set; }

    public decimal CantMinimaCompra { get; set; }

    public double CodPorcDescto1 { get; set; }

    public double CodPorcDescto2 { get; set; }

    public double CodPorcDescto3 { get; set; }

    public double CodPorcDescto4 { get; set; }

    public double PorcentajeDescto { get; set; }

    public double CodCantMinima { get; set; }

    public double CodCantMaxima { get; set; }

    public decimal PMonedaId { get; set; }

    public double PrecioBase { get; set; }

    public double PrecioVigente { get; set; }

    public string CodReferencia { get; set; } = null!;

    public decimal PBodegaId { get; set; }

    public decimal PUbicacionId { get; set; }

    public string Observaciones { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PProductoCodId { get; set; }

    public short TcdCodigo { get; set; }

    public string CodEtiqueta { get; set; } = null!;

    public double CodCantContenedor { get; set; }
}
