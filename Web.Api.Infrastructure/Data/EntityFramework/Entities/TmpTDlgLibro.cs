using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTDlgLibro
{
    public decimal LibLibroCvid { get; set; }

    public decimal PEmpId { get; set; }

    public short TipoLibroId { get; set; }

    public short PerId { get; set; }

    public short TipoEnvioId { get; set; }

    public decimal LibFolioNotificacion { get; set; }

    public string LibCodAutorizacionRec { get; set; } = null!;

    public int LibNumero { get; set; }

    public decimal PLibId { get; set; }

    public byte TipoAccionLcv { get; set; }

    public string CodOwner { get; set; } = null!;

    public decimal PCdoReferenciaId { get; set; }

    public short TdoSii { get; set; }

    public short UblCodigo { get; set; }

    public decimal LibFolioDocto { get; set; }

    public DateTime FechaDocumento { get; set; }

    public string EntRut { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public byte LibIndEmisor { get; set; }

    public string LibIndAnulado { get; set; } = null!;

    public byte LibIndOperacion { get; set; }

    public byte LibIndImpuesto { get; set; }

    public byte LibIndSinCosto { get; set; }

    public double LibTasaImpto { get; set; }

    public short LibTipoDoctoRefer { get; set; }

    public decimal LibFolioDoctoRefer { get; set; }

    public double MtoNeto { get; set; }

    public double MtoExento { get; set; }

    public double MtoIva { get; set; }

    public double MtoIvaUsoComun { get; set; }

    public double MtoIvaNoRetenido { get; set; }

    public double MtoIvaFueraPlazo { get; set; }

    public double MtoIvaPropio { get; set; }

    public double MtoIvaTercero { get; set; }

    public double MtoIvaRetenidoParcial { get; set; }

    public double MtoIvaRetenidoTotal { get; set; }

    public double MtoIvaCredito { get; set; }

    public double MtoImptoRetenSinCred { get; set; }

    public double MtoNetoAfijo { get; set; }

    public double MtoIvaAfijo { get; set; }

    public double MtoTotal { get; set; }

    public double MtoTabPuro { get; set; }

    public double MtoTabCigarro { get; set; }

    public double MtoTabElaborado { get; set; }

    public double MtoImptoVehiculo { get; set; }

    public double MtoNoFacturable { get; set; }

    public double MtoTotalPeriodo { get; set; }

    public double MtoPasajeNac { get; set; }

    public double MtoPasajeInt { get; set; }
}
