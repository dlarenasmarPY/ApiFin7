using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemColumnasInf
{
    public decimal ClmInfId { get; set; }

    public string ClmIcodigo { get; set; } = null!;

    public string ClmIdescripcion { get; set; } = null!;

    public int ClmIorden { get; set; }

    public byte ClmIindAccesorio { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte ItmPrevired { get; set; }

    public virtual ICollection<RhuTRemInformesCol> RhuTRemInformesCols { get; } = new List<RhuTRemInformesCol>();
}
