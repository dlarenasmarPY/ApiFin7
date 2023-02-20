using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTDesgloseImp
{
    public decimal PCabLlgId { get; set; }

    public byte SisCodOri { get; set; }

    public int ImpSiiId { get; set; }

    public double ImpSiiTasa { get; set; }

    public double Monto { get; set; }

    public byte ConSinCredito { get; set; }

    public short ClcId { get; set; }

    public double MontoLocal { get; set; }

    public double MontoConversion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
