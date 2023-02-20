using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntLaborale
{
    public decimal AntLabId { get; set; }

    public decimal PFicPerId { get; set; }

    public DateTime LabFecInicio { get; set; }

    public DateTime LabFecTermino { get; set; }

    public string LabEntRazonSocial { get; set; } = null!;

    public string LabEntDirDireccion { get; set; } = null!;

    public int CmuCodigo { get; set; }

    public string LabEntDirFono { get; set; } = null!;

    public short CgoCodCargo { get; set; }

    public decimal PCausalLegId { get; set; }

    public string LabReferencia1 { get; set; } = null!;

    public string LabRefCargo1 { get; set; } = null!;

    public string LabReferencia2 { get; set; } = null!;

    public string LabRefCargo2 { get; set; } = null!;

    public string LabReferencia3 { get; set; } = null!;

    public string LabRefCargo3 { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParCargo CgoCodCargoNavigation { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual ICollection<RhuTSelRefPostulante> RhuTSelRefPostulantes { get; } = new List<RhuTSelRefPostulante>();
}
