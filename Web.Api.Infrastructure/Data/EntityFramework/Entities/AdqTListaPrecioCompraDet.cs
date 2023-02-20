using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTListaPrecioCompraDet
{
    public decimal ListaPreDetId { get; set; }

    public decimal PListaPreCabId { get; set; }

    public int Linea { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public decimal PProductoCodId { get; set; }

    public decimal PUnidadMedCompraId { get; set; }

    public double PrecioUni { get; set; }

    public decimal PMonedaId { get; set; }

    public double DesctoPorc1 { get; set; }

    public double DesctoPorc2 { get; set; }

    public double DesctoPorc3 { get; set; }

    public double DesctoPorc4 { get; set; }

    public double TotalDesctoPorc { get; set; }

    public short PlazoEntrega { get; set; }

    public double CantMinimaComp { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual AdqTListaPrecioCompraCab PListaPreCab { get; set; } = null!;

    public virtual GlbTMoneda PMoneda { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedCompra { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedStock { get; set; } = null!;
}
