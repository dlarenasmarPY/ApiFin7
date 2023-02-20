using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTInformeGerencialDetCantidad
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PTprId { get; set; }

    public int Periodo { get; set; }

    public int NumeroInforme { get; set; }

    public string CodigoEstado { get; set; } = null!;

    public int PeriodoDet { get; set; }

    public int CantidadProg { get; set; }

    public int CantidadReal { get; set; }

    public int MaxFinal { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
