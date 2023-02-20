using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicCertificacione
{
    public decimal AntCertId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PItmParId { get; set; }

    public DateTime CertFecVigIni { get; set; }

    public DateTime CertFecVigFin { get; set; }

    public int CertCreditos { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmPar { get; set; } = null!;
}
