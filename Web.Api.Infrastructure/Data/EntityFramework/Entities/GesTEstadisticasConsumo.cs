using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GesTEstadisticasConsumo
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short EjeAno { get; set; }

    public short PerId { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PProductoId { get; set; }

    public byte SituacionContCod { get; set; }

    public byte EstadoProdCod { get; set; }

    public decimal CantSalidas { get; set; }

    public decimal CantEntradas { get; set; }

    public decimal ValorSalidas { get; set; }

    public decimal ValorEntradas { get; set; }

    public int NumSalidas { get; set; }

    public int NumEntradas { get; set; }

    public double EstConsConsumo { get; set; }

    public byte PerCalPromConsumo { get; set; }

    public short DiasporPeriodo { get; set; }

    public short DiasxMes { get; set; }

    public double EstConsSumaHist { get; set; }

    public double EstConsPromMensual { get; set; }

    public double EstConsPromPorPeri { get; set; }

    public string IdUsuario { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
