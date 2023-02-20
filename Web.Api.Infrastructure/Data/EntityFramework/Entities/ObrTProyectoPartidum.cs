using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ObrTProyectoPartidum
{
    public decimal PartidaId { get; set; }

    public int PproyectoId { get; set; }

    public string ParExternoId { get; set; } = null!;

    public byte MonCodigo { get; set; }

    public DateTime FechaCambioOrigen { get; set; }

    public int OrigenPartida { get; set; }

    public string CodigoUnidadMedida { get; set; } = null!;

    public decimal CantidadPresupuestada { get; set; }

    public decimal CostoUnitarioPartida { get; set; }

    public decimal CostoTotalPresupuestadoPartida { get; set; }

    public decimal CostoUnitarioNegociado { get; set; }

    public decimal CostoTotalNegociado { get; set; }

    public decimal PrecioUnitarioPartida { get; set; }

    public decimal IngresoPresupuestado { get; set; }

    public DateTime FechaInicioPresupuesto { get; set; }

    public DateTime FechaTerminoPresupuesto { get; set; }

    public DateTime FechaInicioReal { get; set; }

    public DateTime FechaTerminoReal { get; set; }

    public short CodigoEstadoPartida { get; set; }

    public int NumeroOt { get; set; }

    public DateTime FechaCreacionOt { get; set; }

    public byte TipoCostoPartida { get; set; }

    public byte TipoPartida { get; set; }

    public int PpartidaCatalogoId { get; set; }

    public string AnexoDescripcion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string? IdFuncionUltModifReg { get; set; }
}
