using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosEspTecCab
{
    public decimal ProductoEspTecId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PIdiomaEspId { get; set; }

    public string GlosaCortaEspTec { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PServicioId { get; set; }

    public virtual ICollection<AdqTCotizacionDetEspTec> AdqTCotizacionDetEspTecs { get; } = new List<AdqTCotizacionDetEspTec>();

    public virtual ICollection<AdqTOcDetEspTec> AdqTOcDetEspTecs { get; } = new List<AdqTOcDetEspTec>();

    public virtual ICollection<ExiTProductosEspTecDet> ExiTProductosEspTecDets { get; } = new List<ExiTProductosEspTecDet>();

    public virtual ICollection<LogTPedidoMaterialDetEspTec> LogTPedidoMaterialDetEspTecs { get; } = new List<LogTPedidoMaterialDetEspTec>();

    public virtual ExiTIdiomaEspTecnica PIdiomaEsp { get; set; } = null!;

    public virtual ExiTProducto PProducto { get; set; } = null!;
}
