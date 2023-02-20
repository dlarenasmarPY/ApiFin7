using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTTablaDatosLicen
{
    public int BitFicLinea { get; set; }

    public string BitFicArchivo { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public string EntRut { get; set; } = null!;

    public int NroContrato { get; set; }

    public string LicNroLicencia { get; set; } = null!;

    public DateTime LicFecEmision { get; set; }

    public DateTime LicFecInicio { get; set; }

    public short LicDias { get; set; }

    public DateTime LicFecTermino { get; set; }

    public bool LicProrroga { get; set; }

    public string LicNroLicenProrroga { get; set; } = null!;

    public decimal TipoLicencia { get; set; }

    public string RutFamiliar { get; set; } = null!;

    public bool LicIndRecupLab { get; set; }

    public DateTime AccFecha { get; set; }

    public byte AccTrayecto { get; set; }

    public bool LicIndTramInv { get; set; }

    public string AccNroAccidente { get; set; } = null!;

    public decimal TipoReposo { get; set; }

    public decimal LugarReposo { get; set; }

    public string LicDireccion { get; set; } = null!;

    public string LicFono { get; set; } = null!;

    public decimal TramoReposo { get; set; }

    public string MedRut { get; set; } = null!;

    public string IdUsuario { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;
}
