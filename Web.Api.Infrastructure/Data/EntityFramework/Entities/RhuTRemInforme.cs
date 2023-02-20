using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemInforme
{
    public decimal InfRemId { get; set; }

    public string InfRtipo { get; set; } = null!;

    public string InfRcodigo { get; set; } = null!;

    public string InfRdescripcion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTRemInformesCol> RhuTRemInformesCols { get; } = new List<RhuTRemInformesCol>();
}
