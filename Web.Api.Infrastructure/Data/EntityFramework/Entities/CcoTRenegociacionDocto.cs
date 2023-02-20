using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRenegociacionDocto
{
    public decimal RenDocId { get; set; }

    public decimal PRenCabId { get; set; }

    public short TdoId { get; set; }

    public string RenDocNumero { get; set; } = null!;

    public short RenDocNumCuota { get; set; }

    public DateTime RenDocFecVenc { get; set; }

    public double RenDocMontoCapital { get; set; }

    public double RenDocMontoLocalCapital { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PLineaProdId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public string RenDocOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
