using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFnqBasis
{
    public decimal FnqBasId { get; set; }

    public decimal PEmpId { get; set; }

    public DateTime FnqBasFecInicio { get; set; }

    public DateTime FnqBasFecTermino { get; set; }

    public decimal PProcRemId { get; set; }

    public decimal PAntgRemId { get; set; }

    public decimal PSvacRemId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PAuNoJusRemId { get; set; }

    public virtual ICollection<RhuTFnqBasesDet> RhuTFnqBasesDets { get; } = new List<RhuTFnqBasesDet>();
}
