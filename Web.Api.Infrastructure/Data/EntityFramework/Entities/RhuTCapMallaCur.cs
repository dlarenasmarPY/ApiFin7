using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapMallaCur
{
    public decimal CapMallaId { get; set; }

    public decimal PEmpId { get; set; }

    public short CgoCodCargo { get; set; }

    public decimal PCapCurId { get; set; }

    public decimal PItmParId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapCurso PCapCur { get; set; } = null!;

    public virtual ICollection<RhuTCapMallaGen> RhuTCapMallaGens { get; } = new List<RhuTCapMallaGen>();
}
