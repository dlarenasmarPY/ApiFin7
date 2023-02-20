using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RespDlgTRecepcionDet
{
    public decimal RecepcionDetId { get; set; }

    public decimal PEmpId { get; set; }

    public string RecDetRutEmisor { get; set; } = null!;

    public int DlcFolioDocto { get; set; }

    public short TdoSii { get; set; }

    public DateTime RecFechaEmision { get; set; }

    public double RecMontoTotal { get; set; }

    public byte RecDetEstado { get; set; }

    public decimal PRecepcionCabId { get; set; }

    public decimal PRecepcionRespId { get; set; }

    public DateTime RecDetFechaRecepcion { get; set; }

    public string RecDetXml { get; set; } = null!;

    public string RecDetOwner { get; set; } = null!;

    public string RecXmlReciboMercaderias { get; set; } = null!;

    public decimal PEntIdFirma { get; set; }

    public DateTime RecDetFecFirma { get; set; }

    public DateTime RecDetFecEnvia { get; set; }

    public decimal PCabLlgId { get; set; }

    public decimal PRecepcionMercServicioId { get; set; }

    public byte RechazoCod { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal FolioRef { get; set; }

    public string DvcNumOrdenC { get; set; } = null!;

    public byte TedCodigo { get; set; }

    public string AccionReclamo { get; set; } = null!;

    public DateTime FechaReclamo { get; set; }

    public DateTime RecFechaSii { get; set; }
}
