using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTEntidadCobModalidad
{
    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public byte ModCcoCod { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PCtaIdCredito { get; set; }

    public decimal PCreIdCredito { get; set; }

    public int CdiCodigoCredito { get; set; }

    public decimal PTprIdCredito { get; set; }

    public int PryNumCredito { get; set; }

    public short TdoIdCredito { get; set; }

    public decimal PCtaIdLiq { get; set; }

    public decimal PCreIdLiq { get; set; }

    public int CdiCodigoLiq { get; set; }

    public decimal PTprIdLiq { get; set; }

    public int PryNumLiq { get; set; }

    public short TdoIdLiq { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
