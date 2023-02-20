using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFlegDefGral
{
    public decimal FlegDefId { get; set; }

    public decimal PEmpId { get; set; }

    public byte FlegDefInd { get; set; }

    public byte FlegDefDiasBase { get; set; }

    public DateTime FlegDefFecAbono { get; set; }

    public byte FlegDefCorteIni { get; set; }

    public byte FlegDefCorteFin { get; set; }

    public decimal PConcRemId { get; set; }

    public decimal PConcRemFl { get; set; }

    public decimal PConcRemPr { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PConcRemBv { get; set; }

    public byte FlegDiasBaseBon { get; set; }

    public byte FlegDefIndRecep { get; set; }

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;

    public virtual RhuTRemConcepto PConcRemFlNavigation { get; set; } = null!;

    public virtual RhuTRemConcepto PConcRemPrNavigation { get; set; } = null!;
}
