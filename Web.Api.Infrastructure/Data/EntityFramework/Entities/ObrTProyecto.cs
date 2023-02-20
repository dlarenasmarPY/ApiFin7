using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ObrTProyecto
{
    public decimal ProyectoId { get; set; }

    public int EmpIdObr { get; set; }

    public string ProExternoId { get; set; } = null!;

    public string GlosaProyecto { get; set; } = null!;

    public short NumeroVersion { get; set; }

    public DateTime FechaVersion { get; set; }

    public short DivCodigo { get; set; }

    public bool IndControlCcosto { get; set; }

    public int CreCodigo { get; set; }

    public string UbicacionObra { get; set; } = null!;

    public string NombreComuna { get; set; } = null!;

    public string NombreCiudad { get; set; } = null!;

    public short IdPais { get; set; }

    public string Telefono { get; set; } = null!;

    public string RutResponsable { get; set; } = null!;

    public string NombreResponsable { get; set; } = null!;

    public string RutResponsableEpr { get; set; } = null!;

    public string NombreResponsableEpr { get; set; } = null!;

    public byte MonedaCosto { get; set; }

    public DateTime? FechaCambioCosto { get; set; }

    public byte? MonedaVenta { get; set; }

    public DateTime? FechaCambioVenta { get; set; }

    public DateTime FechaInicioPpto { get; set; }

    public DateTime FechaTerminoPpto { get; set; }

    public DateTime FechaInicioReal { get; set; }

    public DateTime FechaTerminoReal { get; set; }

    public short CodigoEstadoProyecto { get; set; }

    public bool IndEstadoMandante { get; set; }

    public short CodigoTipoReajuste { get; set; }

    public short CodigoPeriodicidadReajuste { get; set; }

    public short CodigoPeriodicidadPpto { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte RegCodigo { get; set; }

    public short TipoProyecto { get; set; }

    public DateTime FechaPresentacionPropuesta { get; set; }

    public decimal ValorDiarioCosto { get; set; }

    public decimal ValorDiarioVenta { get; set; }

    public double ObrFactorMoneda { get; set; }
}
