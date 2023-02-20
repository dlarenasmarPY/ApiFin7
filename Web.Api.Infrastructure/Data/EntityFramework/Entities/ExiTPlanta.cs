using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTPlanta
{
    public decimal PlantaId { get; set; }

    public int PlantaCod { get; set; }

    public string PlantaDes { get; set; } = null!;

    public string PlantaDir { get; set; } = null!;

    public byte RegCodigo { get; set; }

    public int CmuCodigo { get; set; }

    public int CiuCodigo { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte IndClienteRetail { get; set; }

    public virtual ICollection<ExiTBodega> ExiTBodegas { get; } = new List<ExiTBodega>();

    public virtual ICollection<ExiTCentroConsumo> ExiTCentroConsumos { get; } = new List<ExiTCentroConsumo>();
}
