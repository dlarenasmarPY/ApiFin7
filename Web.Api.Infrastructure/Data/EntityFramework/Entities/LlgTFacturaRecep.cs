using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTFacturaRecep
{
    public decimal FactRecepId { get; set; }

    public decimal PCabLlgId { get; set; }

    public decimal POpeLogtCabId { get; set; }

    public decimal POpeLogtDetId { get; set; }

    public decimal PDocOrigenId { get; set; }

    public short TdoId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public double CantEntrada { get; set; }

    public double ValorUniOpeMoneda { get; set; }

    public double ValorOpeMoneda { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public int Linea { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PMonedaId { get; set; }
}
