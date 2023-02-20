using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRenegociacionGasto
{
    public decimal RenGasId { get; set; }

    public decimal PRenCabId { get; set; }

    public decimal PTipGastoId { get; set; }

    public decimal PMonedaId { get; set; }

    public short TdoId { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public decimal RenGasMontoImpuDebe { get; set; }

    public decimal RenGasMontoImpuHaber { get; set; }

    public decimal RenGasMontoLocalDebe { get; set; }

    public decimal RenGasMontoLocalHaber { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PLineaProdId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public short CuotasConvenio { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
