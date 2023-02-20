using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTDespachoConceptoDet
{
    public decimal DespachoDetId { get; set; }

    public decimal PDespachoCabId { get; set; }

    public int Linea { get; set; }

    public string CodigoArticulo { get; set; } = null!;

    public string DescripcionTec { get; set; } = null!;

    public decimal PUnidadMedId { get; set; }

    public double Cantidad { get; set; }

    public double PrecioUnitario { get; set; }

    public double ValorTotal { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
