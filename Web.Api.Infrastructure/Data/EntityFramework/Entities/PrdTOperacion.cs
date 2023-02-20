using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOperacion
{
    public decimal OperacionId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PSeccionId { get; set; }

    public string OperacionCod { get; set; } = null!;

    public string OperacionDes { get; set; } = null!;

    public decimal PUnidadRendimientoId { get; set; }

    public double FactorMobraMaqEstd { get; set; }

    public double FactorMobraMaqReal { get; set; }

    public byte IndInfAvance { get; set; }

    public byte IndPrograma { get; set; }

    public byte IndControlada { get; set; }

    public double CostoEstandarTrib { get; set; }

    public double CostoEstandar { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }
}
