using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntEmergencium
{
    public decimal AntEmgId { get; set; }

    public decimal PFicPerId { get; set; }

    public string EmgEntRazonSocial1 { get; set; } = null!;

    public string EmgEntDirDireccion1 { get; set; } = null!;

    public string EmgEntDirFono1 { get; set; } = null!;

    public string EmgEntRazonSocial2 { get; set; } = null!;

    public string EmgEntDirDireccion2 { get; set; } = null!;

    public string EmgEntDirFono2 { get; set; } = null!;

    public decimal PItmGruSanId { get; set; }

    public byte EmgIndAlergia { get; set; }

    public string EmgDescripcion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmGruSan { get; set; } = null!;
}
