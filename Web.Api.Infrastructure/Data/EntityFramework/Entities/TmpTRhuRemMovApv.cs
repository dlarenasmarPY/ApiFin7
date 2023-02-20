using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemMovApv
{
    public decimal IlgMovId { get; set; }

    public string CodOwner { get; set; } = null!;

    public byte ClmIindAccesorio { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public byte PreviApvTipo { get; set; }

    public short PreviRedCodInsApv { get; set; }

    public byte PreviRedFormaPagoApv { get; set; }

    public string ApvNumPoliza { get; set; } = null!;

    public decimal ApvValor { get; set; }

    public double CtoApvcAporte { get; set; }

    public decimal DepConvValor { get; set; }

    public DateTime ApvFecVigencia { get; set; }

    public DateTime ApvFecTermino { get; set; }

    public int IlgSecApv { get; set; }

    public double IlgApvcAporteEmp { get; set; }

    public double IlgApvcAporteTrab { get; set; }

    public double IlgApvcAhorroVol { get; set; }

    public decimal PEntId { get; set; }

    public decimal PInsParId { get; set; }
}
