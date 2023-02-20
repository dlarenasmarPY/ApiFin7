using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTCotizacionDetResp
{
    public decimal CotizDetRespId { get; set; }

    public decimal PCotizDetId { get; set; }

    public decimal PListaPreDetId { get; set; }

    public byte IndModificaPrecio { get; set; }

    public double CantidadCompra { get; set; }

    public double CantidadAdjudica { get; set; }

    public decimal PUnidadMedCompraId { get; set; }

    public byte IndConverPreDefinida { get; set; }

    public double UnidadMedConversion { get; set; }

    public byte UnidadMedMultDivide { get; set; }

    public double CantidadStock { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public short PlazoEntrega { get; set; }

    public double CantMinimaComp { get; set; }

    public double PrecioUni { get; set; }

    public double DesctoPorc1 { get; set; }

    public double DesctoPorc2 { get; set; }

    public double DesctoPorc3 { get; set; }

    public double DesctoPorc4 { get; set; }

    public double TotalDesctoPorc { get; set; }

    public byte IndAdjudicacion { get; set; }

    public decimal PTipoAdjudicaId { get; set; }

    public string AdqGlosa { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual AdqTCotizacionDet PCotizDet { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedCompra { get; set; } = null!;
}
