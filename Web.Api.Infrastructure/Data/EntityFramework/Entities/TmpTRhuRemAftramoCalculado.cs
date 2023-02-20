using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemAftramoCalculado
{
    public decimal PFicPerId { get; set; }

    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public byte AftramoTipCto { get; set; }

    public decimal PTramoId { get; set; }

    public double LqTtimponibleProm { get; set; }

    public decimal PTramoIdNew { get; set; }

    public string AftramoEst { get; set; } = null!;

    public int EjeAnoMesIni { get; set; }

    public int EjeAnoMesFin { get; set; }
}
