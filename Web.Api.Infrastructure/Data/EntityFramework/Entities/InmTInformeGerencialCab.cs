using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTInformeGerencialCab
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PTprId { get; set; }

    public int Periodo { get; set; }

    public int TipoOpcion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int NumeroInforme { get; set; }

    public string CodigoEstado { get; set; } = null!;

    public double PorCumplUnidades { get; set; }

    public double PorCumplMonto { get; set; }

    public DateTime ProyeccionCantidad { get; set; }

    public double Qfaltante { get; set; }

    public double Uffaltante { get; set; }

    public int CantDesest { get; set; }

    public int CantEscri { get; set; }

    public string FotoPortada { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
