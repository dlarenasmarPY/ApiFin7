using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemAuditorium
{
    public decimal RemAudId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PProcRemPerId { get; set; }

    public string RemAudProceso { get; set; } = null!;

    public string RemAudTipoProceso { get; set; } = null!;

    public string RemAudUsuProceso { get; set; } = null!;

    public DateTime RemAudFecProceso { get; set; }

    public string RemAudUsuVb { get; set; } = null!;

    public DateTime RemAudFecVb { get; set; }

    public decimal PRemAudId { get; set; }

    public decimal PRemAudRevId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
