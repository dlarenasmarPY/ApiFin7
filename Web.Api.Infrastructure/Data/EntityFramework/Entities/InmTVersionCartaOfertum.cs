using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTVersionCartaOfertum
{
    public decimal CartaOfertaId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public int CarOfeNumInterno { get; set; }

    public decimal PCotizacionId { get; set; }

    public DateTime CarOfeFecha { get; set; }

    public byte DocEstado { get; set; }

    public int VenIdResp { get; set; }

    public int VenIdCierre { get; set; }

    public decimal PEntId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public short TventaId { get; set; }

    public double PrecioLista { get; set; }

    public double PrecioVenta { get; set; }

    public double PrecioVentaInm { get; set; }

    public double PorcDescto { get; set; }

    public double MontoDescto { get; set; }

    public byte IndDescPrecVenta { get; set; }

    public int ContratoNumInterno { get; set; }

    public DateTime FechaContrato { get; set; }

    public short TipoDesId { get; set; }

    public int CtrSanumInterno { get; set; }

    public decimal PCabOpeIdPro { get; set; }

    public decimal PCabOpeIdEsc { get; set; }

    public int VenIdEscritura { get; set; }

    public byte IndAutDescto { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public DateTime FechaPromesa { get; set; }

    public DateTime FechaDesist { get; set; }

    public DateTime FechaEscrit { get; set; }

    public DateTime FechaPagoTot { get; set; }

    public DateTime FechaTraspaso { get; set; }

    public string ObservacionCoferta { get; set; } = null!;

    public decimal PCabOpeIdProVen { get; set; }

    public byte DesComId { get; set; }

    public double MontoBono { get; set; }

    public byte PromesaAut { get; set; }

    public double PorcBono { get; set; }

    public double MontoDectoItem { get; set; }

    public double PrecioFinalCo { get; set; }

    public int NumeroVersion { get; set; }
}
