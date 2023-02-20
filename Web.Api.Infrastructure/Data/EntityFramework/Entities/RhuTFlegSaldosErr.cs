using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFlegSaldosErr
{
    public int CorrelativoExp { get; set; }

    public decimal PEmpId { get; set; }

    public int Linea { get; set; }

    public string EntRut { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string FlegIniRuta { get; set; } = null!;

    public string FlegIniArchivo { get; set; } = null!;

    public DateTime FlegIniFecha { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
