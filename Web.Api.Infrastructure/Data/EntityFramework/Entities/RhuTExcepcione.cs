using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTExcepcione
{
    public decimal ExcId { get; set; }

    public decimal POrigenId { get; set; }

    public decimal PExcEsaId { get; set; }

    public decimal PFecEveId { get; set; }

    public decimal PCtoId { get; set; }

    public DateTime ExcFecInicio { get; set; }

    public DateTime ExcFecTermino { get; set; }

    public double ExcDias { get; set; }

    public short ExcDiasInf { get; set; }

    public short ExcDiasSdo { get; set; }

    public DateTime ExcHraInicio { get; set; }

    public DateTime ExcHraTermino { get; set; }

    public double ExcHoras { get; set; }

    public decimal PItmEstExcDiaId { get; set; }

    public DateTime ExcFecIngReg { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTExcPago> RhuTExcPagos { get; } = new List<RhuTExcPago>();
}
