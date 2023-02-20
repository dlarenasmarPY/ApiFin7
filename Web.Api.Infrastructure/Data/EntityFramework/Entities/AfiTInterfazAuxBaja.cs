using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTInterfazAuxBaja
{
    public decimal IntIntId { get; set; }

    public string IntTmpOwner { get; set; } = null!;

    public string IntBitArchivo { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short AfiGrupoCod { get; set; }

    public decimal AfiCodigo { get; set; }

    public decimal AfiSecuencia { get; set; }

    public decimal AfiOpeCod { get; set; }

    public DateTime AfiFechaIngBaja { get; set; }

    public decimal AfiDctoDigitacion { get; set; }

    public string AfiDctoLegal { get; set; } = null!;

    public byte AfiTipoCalculoCod { get; set; }

    public double AfiValorBajaMoneda { get; set; }

    public byte IntError { get; set; }

    public short AfiSubGrpCod { get; set; }

    public string AfiCodAnterior { get; set; } = null!;

    public string AfiCodSerie { get; set; } = null!;
}
