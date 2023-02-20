using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTNominaIntCab
{
    public decimal CabNomId { get; set; }

    public byte TipNomCod { get; set; }

    public int CabNomNumNomina { get; set; }

    public DateTime CabNomFecNomina { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string CabNomCobrador { get; set; } = null!;

    public decimal PEntIdRecaudador { get; set; }

    public double CabNomMontoRecaudado { get; set; }

    public byte CabNomEstado { get; set; }

    public DateTime CabNomFecEstado { get; set; }

    public short UniCodigoCon { get; set; }

    public string CabNomOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
