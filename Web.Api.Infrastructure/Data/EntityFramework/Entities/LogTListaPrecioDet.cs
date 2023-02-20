using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTListaPrecioDet
{
    public decimal ListaPreDetId { get; set; }

    public decimal PListaPreCabId { get; set; }

    public int Linea { get; set; }

    public byte TipoItem { get; set; }

    public decimal PProductoCodId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PCategoriaId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public short PlazoEntrega { get; set; }

    public double CantMinimaComp { get; set; }

    public byte TipoPrecio { get; set; }

    public double PrecioUnitario { get; set; }

    public double PrecioMinimo { get; set; }

    public double PrecioReferencial { get; set; }

    public decimal PMonedaId { get; set; }

    public DateTime FechaDesde { get; set; }

    public DateTime FechaHasta { get; set; }

    public byte DetDocTrib { get; set; }

    public decimal PDescuentoId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
