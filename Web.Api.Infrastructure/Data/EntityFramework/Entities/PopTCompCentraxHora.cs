using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTCompCentraxHora
{
    public int EmpId { get; set; }

    public short DivCodigo { get; set; }

    public int CfgNumId { get; set; }

    public short PerId { get; set; }

    public short UniCodigo { get; set; }

    public short TesTdoId { get; set; }

    public int TesDocNumInterno { get; set; }

    public int TesDocNumReversa { get; set; }

    public byte TesDocEstado { get; set; }

    public decimal HorasMensuales { get; set; }

    public int EmpIdRem { get; set; }

    public short DivCodigoRem { get; set; }

    public short UniCodigoRem { get; set; }

    public short TesTdoIdRem { get; set; }

    public int TesDocNumInternoRem { get; set; }

    public int TesDocNumReversaRem { get; set; }
}
