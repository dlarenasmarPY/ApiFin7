using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemInfAfp
{
    public string CodOwner { get; set; } = null!;

    public decimal PLiqId { get; set; }

    public int IlgSecDeclaracion { get; set; }

    public string PerRut { get; set; } = null!;

    public string FicEntRazonSocial { get; set; } = null!;

    public decimal PItmIntegroId { get; set; }

    public string ItmDescripcion { get; set; } = null!;

    public decimal PAfpParId { get; set; }

    public string AfpRazonSocial { get; set; } = null!;

    public string RutEmpleador { get; set; } = null!;

    public double RemunImpFondo { get; set; }

    public double CotizObligatoria { get; set; }

    public double DepCuentaAhorro { get; set; }

    public double RemunImpSegC { get; set; }

    public double CotizAfiliado { get; set; }

    public double CotizEmpleador { get; set; }

    public string PreIndPrevisional { get; set; } = null!;

    public string IlgTipMovtoPers { get; set; } = null!;

    public DateTime IlgFecIniMovtoPers { get; set; }

    public DateTime IlgFecTerMovtoPers { get; set; }

    public string IlgRutEntidadPag { get; set; } = null!;

    public double IlgSegCesTrabajador { get; set; }

    public double IlgComisionFp { get; set; }

    public decimal IlgAporteComisionAfp { get; set; }

    public decimal IlgAporteComisionAfpacc { get; set; }
}
