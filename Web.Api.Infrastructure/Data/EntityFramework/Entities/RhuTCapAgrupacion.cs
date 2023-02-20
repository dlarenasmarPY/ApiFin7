using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapAgrupacion
{
    public decimal CapAgrId { get; set; }

    public decimal PEmpId { get; set; }

    public string CapAgrNombre { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTCapAgrupaDet> RhuTCapAgrupaDets { get; } = new List<RhuTCapAgrupaDet>();
}
