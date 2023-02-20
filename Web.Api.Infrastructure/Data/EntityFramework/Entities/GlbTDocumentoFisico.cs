using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTDocumentoFisico
{
    public decimal DocFisId { get; set; }

    public byte SisCodOri { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short TdoId { get; set; }

    public string DocFisNumero { get; set; } = null!;

    public decimal PDocumentoId { get; set; }

    public string DocFisRuta { get; set; } = null!;

    public string DocFisArchivo { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PEntId { get; set; }

    public string IdFuncionalidad { get; set; } = null!;
}
