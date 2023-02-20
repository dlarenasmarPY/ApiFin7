using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCalculoComisionRezagado
{
    public decimal PEmpId { get; set; }

    public decimal PTprId { get; set; }

    public int Periodo { get; set; }

    public byte TipoOpe { get; set; }

    public double Monto { get; set; }

    public decimal PinmuebleId { get; set; }

    public string Usuario { get; set; } = null!;

    public decimal PCartaOfertaId { get; set; }

    public double PorcComision { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
