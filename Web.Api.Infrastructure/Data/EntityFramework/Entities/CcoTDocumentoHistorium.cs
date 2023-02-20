using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTDocumentoHistorium
{
    public decimal DocHisId { get; set; }

    public DateTime DocHisFecReg { get; set; }

    public decimal PDocCceId { get; set; }

    public short MovCceNumCuota { get; set; }

    public decimal PCtaId { get; set; }

    public byte DocCceEstado { get; set; }

    public byte DocCceUbiFisCod { get; set; }

    public byte DocCceSco { get; set; }

    public string DocCceNumCedente { get; set; } = null!;

    public string DocCceNumPagCedente { get; set; } = null!;

    public string DocCceNumDocBanco { get; set; } = null!;

    public decimal PEntIdTer { get; set; }

    public short EntSucNumeroTer { get; set; }

    public decimal PEntCcoId { get; set; }

    public DateTime DocCceFecVenc { get; set; }

    public DateTime DocCceFecProyectada { get; set; }

    public string DocHisGlosa { get; set; } = null!;

    public short ProNegocioCod { get; set; }

    public decimal PDocHisMovId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
