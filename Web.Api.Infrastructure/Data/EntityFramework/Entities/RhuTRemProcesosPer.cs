using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemProcesosPer
{
    public decimal ProcRemPerId { get; set; }

    public decimal PPerRemId { get; set; }

    public decimal PProcRemId { get; set; }

    public DateTime PrpfecFinCalc { get; set; }

    public DateTime PrpfecFinPag { get; set; }

    public decimal CpeReliqDesdePerId { get; set; }

    public decimal CpeReliqHastaPerId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemPeriodo PPerRem { get; set; } = null!;

    public virtual RhuTRemProceso PProcRem { get; set; } = null!;

    public virtual ICollection<RhuTRemNominasConc> RhuTRemNominasConcs { get; } = new List<RhuTRemNominasConc>();
}
