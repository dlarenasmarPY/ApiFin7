using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTSeccion
{
    public decimal SeccionId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string SeccionCod { get; set; } = null!;

    public string SeccionDes { get; set; } = null!;

    public decimal PBodegaIdProceso { get; set; }

    public decimal PBodegaIdGranel { get; set; }

    public decimal PBodegaIdSolicitud { get; set; }

    public decimal PBodegaIdEntrega { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PCconsumoId { get; set; }
}
