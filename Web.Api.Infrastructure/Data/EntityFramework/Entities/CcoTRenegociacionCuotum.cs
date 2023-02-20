using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRenegociacionCuotum
{
    public decimal RenCuoId { get; set; }

    public decimal PRenCabId { get; set; }

    public short RenCuoNumCuota { get; set; }

    public DateTime RenCuoFecVenc { get; set; }

    public double RenCuoMontoCapital { get; set; }

    public double RenCuoMontoInteres { get; set; }

    public double RenCuoMontoGastos { get; set; }

    public double RenCuoMontoLocalCapital { get; set; }

    public double RenCuoMontoLocalInteres { get; set; }

    public double RenCuoMontoLocalGastos { get; set; }

    public short TdoId { get; set; }

    public string RenCuoNumero { get; set; } = null!;

    public int InstCod { get; set; }

    public int PlaCod { get; set; }

    public string DocCceCtaCteBco { get; set; } = null!;

    public int CfiCodigo { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PEntIdSec { get; set; }

    public short EntSucNumeroSec { get; set; }

    public string DocCceDocRef { get; set; } = null!;

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PLineaProdId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public string RenCuoOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
