using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTLicMedico
{
    public decimal MedId { get; set; }

    public string MedRut { get; set; } = null!;

    public string MedNombre { get; set; } = null!;

    public decimal PItmProMedId { get; set; }

    public decimal PItmEspMedId { get; set; }

    public string MedDireccion { get; set; } = null!;

    public string MedFono { get; set; } = null!;

    public string MedEmail { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParItem PItmEspMed { get; set; } = null!;

    public virtual RhuTParItem PItmProMed { get; set; } = null!;

    public virtual ICollection<RhuTLicMedica> RhuTLicMedicas { get; } = new List<RhuTLicMedica>();

    public virtual ICollection<RhuTLicRmedica> RhuTLicRmedicas { get; } = new List<RhuTLicRmedica>();
}
