using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTCotizacionDet
{
    public decimal CotizDetId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PCotizCabId { get; set; }

    public decimal PProCompraDetId { get; set; }

    public byte IndTipoCotizacion { get; set; }

    public byte IndCargoDirecto { get; set; }

    public int Linea { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PServicioId { get; set; }

    public double CantidadCompra { get; set; }

    public decimal PUnidadMedCompraId { get; set; }

    public double UnidadMedConversion { get; set; }

    public byte UnidadMedMultDivide { get; set; }

    public double CantidadStock { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public decimal PProductoEspTecId { get; set; }

    public decimal PGlosaId { get; set; }

    public DateTime FechaMaxCotizacion { get; set; }

    public string AdqGlosa { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<AdqTCotizacionDetEspTec> AdqTCotizacionDetEspTecs { get; } = new List<AdqTCotizacionDetEspTec>();

    public virtual ICollection<AdqTCotizacionDetGlosa> AdqTCotizacionDetGlosas { get; } = new List<AdqTCotizacionDetGlosa>();

    public virtual ICollection<AdqTCotizacionDetResp> AdqTCotizacionDetResps { get; } = new List<AdqTCotizacionDetResp>();

    public virtual AdqTCotizacionCab PCotizCab { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedCompra { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedStock { get; set; } = null!;
}
