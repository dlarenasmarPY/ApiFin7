using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemInfPagoRecibo
{
    public decimal InfPagIdRec { get; set; }

    public string CodOwner { get; set; } = null!;

    public decimal PInfPagId { get; set; }

    public int IdenCorrelativo { get; set; }

    public string IlgBaseReciboHaber { get; set; } = null!;

    public string IlgCnRcodigoHaber { get; set; } = null!;

    public string IlgCnRdescripcionHaber { get; set; } = null!;

    public double IlgLqDvalorHaber { get; set; }

    public double IlgLqDvalorDeflacHaber { get; set; }

    public string IlgBaseReciboDesc { get; set; } = null!;

    public string IlgCnRcodigoDesc { get; set; } = null!;

    public string IlgCnRdescripcionDesc { get; set; } = null!;

    public double IlgLqDvalorDesc { get; set; }

    public double IlgLqDvalorDeflacDesc { get; set; }
}
