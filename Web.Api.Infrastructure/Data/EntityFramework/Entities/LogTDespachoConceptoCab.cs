using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTDespachoConceptoCab
{
    public decimal DespachoCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PTdoId { get; set; }

    public DateTime FechaEmision { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public byte ConEstCod { get; set; }

    public string LogOwner { get; set; } = null!;

    public string GlosaTraslado { get; set; } = null!;

    public string GlosaExis { get; set; } = null!;

    public decimal PDoctoLegalCabId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PDoctoLegalCabHastaId { get; set; }
}
