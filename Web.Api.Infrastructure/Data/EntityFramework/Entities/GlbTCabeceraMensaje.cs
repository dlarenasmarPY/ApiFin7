using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTCabeceraMensaje
{
    public decimal CabMenId { get; set; }

    public decimal CabMenIdentificador { get; set; }

    public string CabMenDe { get; set; } = null!;

    public string CabMenAsunto { get; set; } = null!;

    public string CabMenMensaje { get; set; } = null!;

    public string CabMenIndArchivo { get; set; } = null!;

    public string CabMenArchivo { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
