using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTCtrUsuario
{
    public string CtrUsuFuncionalidad { get; set; } = null!;

    public string CtrUsuUsuario { get; set; } = null!;

    public string CtrUsuIp { get; set; } = null!;

    public int CtrUsuOwner { get; set; }

    public byte CtrUsuEstado { get; set; }

    public DateTime CtrUsuFecha { get; set; }

    public string CtrUsuGlosa { get; set; } = null!;

    public decimal CtrUsuIdentificador { get; set; }
}
