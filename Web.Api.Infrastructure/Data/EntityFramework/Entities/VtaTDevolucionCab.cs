using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTDevolucionCab
{
    public decimal DevolucionCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int DpcNumDocto { get; set; }

    public byte TdpCodigo { get; set; }

    public DateTime FechaDocumento { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public decimal PVendedorId { get; set; }

    public decimal PVendedorDigitaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public string CodOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public decimal POpeLogtCabId { get; set; }

    public decimal PDoctoLegalCabNcid { get; set; }

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string DpcObservacion { get; set; } = null!;

    public decimal PMonedaId { get; set; }
}
