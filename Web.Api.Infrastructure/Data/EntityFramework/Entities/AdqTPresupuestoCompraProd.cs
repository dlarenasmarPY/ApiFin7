using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTPresupuestoCompraProd
{
    public decimal PresupCompraProdId { get; set; }

    public decimal PPresupCompraCatId { get; set; }

    public decimal PCategoriaId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public double MontoPptoProducto { get; set; }

    public double MontoRealProducto { get; set; }

    public double CantidadPptoProducto { get; set; }

    public short PerId { get; set; }

    public short EjeAno { get; set; }

    public byte IndExcesoGasto { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
