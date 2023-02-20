using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTNominaCobCab
{
    public decimal CabNomId { get; set; }

    public byte TipNomCod { get; set; }

    public int CabNomIntNumNomina { get; set; }

    public short PerId { get; set; }

    public DateTime CabNomIntFecNomina { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string CabNomIntCobrador { get; set; } = null!;

    public short UniCodigoCbza { get; set; }

    public string CabNomIntDigUsuario { get; set; } = null!;

    public string CabNomIntRecUsuario { get; set; } = null!;

    public decimal PEntIdRecaudador { get; set; }

    public DateTime CabNomIntFecRendicion { get; set; }

    public double CabNomIntMontoRecaudado { get; set; }

    public byte CabNomIntEstado { get; set; }

    public DateTime CabNomIntFecEstado { get; set; }

    public string CabNomIntOwner { get; set; } = null!;

    public decimal PCabOpeId { get; set; }

    public decimal PCabNomIdOrigen { get; set; }

    public byte IndNomina { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
