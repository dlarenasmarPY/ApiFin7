using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TesTCtaCtesBancariasdet
{
    public decimal CtaCteBcoDetId { get; set; }

    public decimal PCtaCteBcoId { get; set; }

    public int NumChequera { get; set; }

    public bool TipoChequera { get; set; }

    public int NumChequeInicial { get; set; }

    public int NumChequeFinal { get; set; }

    public int NumChequeActual { get; set; }

    public byte EstadoChequera { get; set; }

    public DateTime FecVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
