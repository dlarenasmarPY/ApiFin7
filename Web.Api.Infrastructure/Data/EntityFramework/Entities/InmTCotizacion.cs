using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCotizacion
{
    public decimal CotizacionId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public int CotDocNumInterno { get; set; }

    public DateTime CotFecha { get; set; }

    public byte DocEstado { get; set; }

    public int VenId { get; set; }

    public string CliRut { get; set; } = null!;

    public string CliRazonSocial { get; set; } = null!;

    public string CliSucDireccion { get; set; } = null!;

    public int CliSucCmuCodigo { get; set; }

    public string CliSucFono { get; set; } = null!;

    public short TcliId { get; set; }

    public short AfluId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public double PrecioVenta { get; set; }

    public short TventaId { get; set; }

    public DateTime CotFechaCambio { get; set; }

    public double CotTasaCambio { get; set; }

    public double PrecioLista { get; set; }

    public double PrecioVentaInm { get; set; }

    public double PorcDescto { get; set; }

    public double MontoDescto { get; set; }

    public byte IndDescPrecVenta { get; set; }

    public short ExpId { get; set; }

    public short ConveId { get; set; }

    public string ObservacionInm { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public short ModoId { get; set; }

    public decimal PCategoriaId { get; set; }

    public double PorcBono { get; set; }

    public double MontoBono { get; set; }

    public double PrecioFinalCot { get; set; }

    public int AutorizaCot { get; set; }

    public virtual InmTAfluencium Aflu { get; set; } = null!;

    public virtual InmTTipoCliente Tcli { get; set; } = null!;

    public virtual InmTTipoVentum Tventa { get; set; } = null!;
}
