using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParInterfaz
{
    public decimal IcFseqId { get; set; }

    public string IcFnomFormato { get; set; } = null!;

    public byte IcFtipoInterfaz { get; set; }

    public byte IcFextension { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTCtoNominasCf> RhuTCtoNominasCfs { get; } = new List<RhuTCtoNominasCf>();

    public virtual ICollection<RhuTParInterfazDet> RhuTParInterfazDets { get; } = new List<RhuTParInterfazDet>();
}
