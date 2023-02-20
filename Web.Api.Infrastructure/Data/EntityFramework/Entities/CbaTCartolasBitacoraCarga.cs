using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CbaTCartolasBitacoraCarga
{
    public decimal CarBitId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int InstCod { get; set; }

    public string CarBitArchivo { get; set; } = null!;

    public DateTime CarBitFec { get; set; }

    public string CarBitOwner { get; set; } = null!;

    public byte CarBitEstado { get; set; }

    public string CarBitObservacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PCtaCteBcoId { get; set; }

    public int CarFolio { get; set; }
}
