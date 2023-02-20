using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TesTCtaCtesBancaria
{
    public decimal CtaCteBcoId { get; set; }

    public decimal PEmpId { get; set; }

    public int InstCod { get; set; }

    public string CodCtaCteBco { get; set; } = null!;

    public string CodCtaCteOrigen { get; set; } = null!;

    public short EntSucNumero { get; set; }

    public int PlaCod { get; set; }

    public short DivCodigo { get; set; }

    public DateTime FecVigencia { get; set; }

    public byte CtaCteBcoEstado { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PEntConId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
