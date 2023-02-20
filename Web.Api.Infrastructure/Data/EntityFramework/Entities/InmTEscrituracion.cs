using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTEscrituracion
{
    public decimal PCartaOfertaId { get; set; }

    public int InstCod { get; set; }

    public short CodNotaria { get; set; }

    public int VenId { get; set; }

    public DateTime FechaProceso { get; set; }

    public DateTime FechaEscrit { get; set; }

    public DateTime FechaCalculo { get; set; }

    public double CotTasaCambio { get; set; }

    public double PrecioVentaInm { get; set; }

    public double MontoLocal { get; set; }

    public byte DocEstadoEsc { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
