using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTTipoVehiculo
{
    public decimal TipoVehId { get; set; }

    public string TipoVehCod { get; set; } = null!;

    public string TipoVehDes { get; set; } = null!;

    public double TipoVehCapacidad { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
