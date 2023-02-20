using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTPresupuestoCompraCat
{
    public decimal PresupCompraCatId { get; set; }

    public decimal PPresupCompraId { get; set; }

    public decimal PCategoriaId { get; set; }

    public double MontoPptoCategoria { get; set; }

    public double MontoRealCategoria { get; set; }

    public short PerId { get; set; }

    public short EjeAno { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
