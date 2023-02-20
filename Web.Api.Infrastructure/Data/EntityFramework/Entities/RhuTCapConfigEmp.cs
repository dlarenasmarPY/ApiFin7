using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapConfigEmp
{
    public decimal CapConfId { get; set; }

    public decimal PEmpId { get; set; }

    public byte CapChEmpId { get; set; }

    public byte CapChDivCodigo { get; set; }

    public byte CapChCreCodigo { get; set; }

    public byte CapChOtros { get; set; }

    public byte CapChCargos { get; set; }

    public decimal PTabParId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTCapPresupuesto> RhuTCapPresupuestos { get; } = new List<RhuTCapPresupuesto>();
}
