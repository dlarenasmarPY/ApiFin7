using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalDetImp
{
    public decimal PDoctoLegalCabId { get; set; }

    public decimal PDoctoLegalDetId { get; set; }

    public decimal PImpuestoId { get; set; }

    public double DliPorcentaje { get; set; }

    public double DliMtoImptoEsp { get; set; }

    public double DliMtoImptoEspLocal { get; set; }

    public double DliMtoImptoEspConv { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
