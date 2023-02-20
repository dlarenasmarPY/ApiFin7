using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTDeterioroIfr
{
    public decimal DeterioroIfrsId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public decimal PPcrId { get; set; }

    public int AfiCodigoUge { get; set; }

    public double AfiDeterioro { get; set; }

    public int AfiCantidad { get; set; }

    public double AfiValorNeto { get; set; }

    public double AfiGoodWillInfor { get; set; }

    public double AfiImpRecuperable { get; set; }

    public double AfiRevDeterioro { get; set; }

    public decimal AfiDctoDigitacion { get; set; }

    public byte AfiTipoIngreso { get; set; }

    public byte AfiTipoRegistro { get; set; }

    public DateTime AfiFechaIngreso { get; set; }

    public string AfiUserIngreso { get; set; } = null!;

    public DateTime AfiFechaAprob { get; set; }

    public string AfiUserAprob { get; set; } = null!;

    public string NombreArchivoCarga { get; set; } = null!;

    public byte AfiEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
