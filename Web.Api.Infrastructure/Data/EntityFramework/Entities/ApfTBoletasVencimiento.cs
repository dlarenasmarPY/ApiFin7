using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTBoletasVencimiento
{
    public decimal DetBoletaId { get; set; }

    public decimal PBoletaId { get; set; }

    public int LineaBoleta { get; set; }

    public DateTime Fecha { get; set; }

    public double Monto { get; set; }

    public string BolActUsuario { get; set; } = null!;

    public DateTime BolActFecha { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
