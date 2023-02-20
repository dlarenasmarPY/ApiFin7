using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTLcoRetencionDet
{
    public decimal LcoRetenDetId { get; set; }

    public decimal PLcoRetenId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PFactRecepId { get; set; }

    public double LcoMontoImponible { get; set; }

    public short LcoCodIva { get; set; }

    public decimal LcoPorcIva { get; set; }

    public double LcoMontoIva { get; set; }

    public short LcoCodIvaRet { get; set; }

    public decimal LcoPorcIvaRet { get; set; }

    public double LcoMontoImpuIvaRet { get; set; }

    public double LcoMontoLocalIvaRet { get; set; }

    public double LcoMontoConvIvaRet { get; set; }

    public string LcoCodFuente { get; set; } = null!;

    public decimal LcoPorcFuente { get; set; }

    public double LcoMontoImpuFuenteRet { get; set; }

    public double LcoMontoLocalFuenteRet { get; set; }

    public double LcoMontoConvFuenteRet { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
