using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFnqCalculo
{
    public decimal FnqCalcId { get; set; }

    public decimal PFnqSolDetId { get; set; }

    public decimal PVariRemId { get; set; }

    public double FnqCalcValor { get; set; }

    public decimal PLiqId { get; set; }

    public decimal PItmParId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFnqSolicitudDet PFnqSolDet { get; set; } = null!;

    public virtual RhuTParItem PItmPar { get; set; } = null!;

    public virtual ICollection<RhuTFnqCalculosDet> RhuTFnqCalculosDets { get; } = new List<RhuTFnqCalculosDet>();
}
