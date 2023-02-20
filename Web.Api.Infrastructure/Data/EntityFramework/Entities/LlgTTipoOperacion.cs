using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTTipoOperacion
{
    public decimal TipoOpeId { get; set; }

    public decimal PEmpId { get; set; }

    public short OpeCod { get; set; }

    public string OpeGlosa { get; set; } = null!;

    public short ProNegocioCod { get; set; }

    public decimal PCorId { get; set; }

    public short TcoId { get; set; }

    public byte TcoTipoFuncion { get; set; }

    public DateTime OpeFecVigencia { get; set; }

    public byte SisCodOri { get; set; }

    public short TdoId { get; set; }

    public decimal PMonedaId { get; set; }

    public byte OpeValidaIva { get; set; }

    public byte OpeIndBol { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte Inclu3323 { get; set; }

    public byte IndActivoFijo { get; set; }

    public byte IndIvaTerceros { get; set; }

    public short CodFormulario { get; set; }
}
