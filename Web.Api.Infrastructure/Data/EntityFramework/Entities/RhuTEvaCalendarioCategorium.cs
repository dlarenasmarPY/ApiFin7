using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaCalendarioCategorium
{
    public decimal IdCalendarioCategoria { get; set; }

    public decimal PidCalendario { get; set; }

    public string TipoCategoria { get; set; } = null!;

    public decimal PItmEstCal { get; set; }

    public DateTime FechaEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTEvaCalendario PidCalendarioNavigation { get; set; } = null!;
}
