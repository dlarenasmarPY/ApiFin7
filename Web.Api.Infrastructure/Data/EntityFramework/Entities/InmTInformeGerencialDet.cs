using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTInformeGerencialDet
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PTprId { get; set; }

    public int Periodo { get; set; }

    public int NumeroInforme { get; set; }

    public string CodigoEstado { get; set; } = null!;

    public byte ClasificaId { get; set; }

    public string Descripcion { get; set; } = null!;

    public int CantStock { get; set; }

    public int CantProg { get; set; }

    public double MontoProg { get; set; }

    public int CantReal { get; set; }

    public double MontoReal { get; set; }

    public string Usuario { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
