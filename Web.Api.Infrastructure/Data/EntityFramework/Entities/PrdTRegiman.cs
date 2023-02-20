using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTRegiman
{
    public decimal RegimenId { get; set; }

    public decimal PEmpId { get; set; }

    public string RegimenCod { get; set; } = null!;

    public string RegimenDes { get; set; } = null!;

    public int HorasDomingo { get; set; }

    public int HorasLunes { get; set; }

    public int HorasMartes { get; set; }

    public int HorasMiercoles { get; set; }

    public int HorasJueves { get; set; }

    public int HorasViernes { get; set; }

    public int HorasSabado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
