using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoSubJoven
{
    public short PerId { get; set; }

    public decimal PProcRemId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PNomConcId { get; set; }

    public decimal PNomConcDetId { get; set; }

    public double NcnDvalNumerico { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
