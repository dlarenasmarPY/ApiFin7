using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemLegalesMov
{
    public decimal IlgMovId { get; set; }

    public string CodOwner { get; set; } = null!;

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public string IlgTipMovtoPers { get; set; } = null!;

    public DateTime IlgFecIniMovtoPers { get; set; }

    public DateTime IlgFecTerMovtoPers { get; set; }

    public int IlgSecMovto { get; set; }

    public string IlgRutEntidadPag { get; set; } = null!;

    public short IlgCodSucEntidadPag { get; set; }

    public string IlgDescSucEntidadPag { get; set; } = null!;

    public string IlgCmuNombre { get; set; } = null!;

    public string IlgRegId { get; set; } = null!;
}
