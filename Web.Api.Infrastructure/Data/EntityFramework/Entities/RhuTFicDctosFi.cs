using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicDctosFi
{
    public decimal DctoFisId { get; set; }

    public decimal PFicPerId { get; set; }

    public DateTime DctoFisFecIni { get; set; }

    public DateTime DctoFisFecTer { get; set; }

    public string DctoFisDescripcion { get; set; } = null!;

    public decimal PItmParId { get; set; }

    public string DctoFisRuta { get; set; } = null!;

    public string DctoFisArchivo { get; set; } = null!;

    public decimal PItmDocEstadoId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmDocEstado { get; set; } = null!;
}
