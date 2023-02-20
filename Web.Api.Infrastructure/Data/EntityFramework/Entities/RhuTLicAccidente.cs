using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTLicAccidente
{
    public decimal AccId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public string AccNroAccidente { get; set; } = null!;

    public byte AccTrayecto { get; set; }

    public DateTime AccFecha { get; set; }

    public DateTime AccHora { get; set; }

    public decimal PItmTipAccId { get; set; }

    public string AccTipoDesc { get; set; } = null!;

    public decimal PItmIncAccId { get; set; }

    public string AccIncapDesc { get; set; } = null!;

    public decimal PItmAgeAccId { get; set; }

    public string AccAgenteDesc { get; set; } = null!;

    public bool AccIndLic { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmAgeAcc { get; set; } = null!;

    public virtual RhuTParItem PItmIncAcc { get; set; } = null!;

    public virtual RhuTParItem PItmTipAcc { get; set; } = null!;

    public virtual ICollection<RhuTLicMedica> RhuTLicMedicas { get; } = new List<RhuTLicMedica>();

    public virtual ICollection<RhuTLicRmedica> RhuTLicRmedicas { get; } = new List<RhuTLicRmedica>();
}
