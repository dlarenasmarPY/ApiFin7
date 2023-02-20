using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemProcCentraliza
{
    public decimal ProcCenId { get; set; }

    public decimal PProcRemPerId { get; set; }

    public byte ProEstado { get; set; }

    public decimal PCabOpeId { get; set; }

    public decimal PCabOpeIdReversa { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTRemProcCentralizaDet> RhuTRemProcCentralizaDets { get; } = new List<RhuTRemProcCentralizaDet>();
}
