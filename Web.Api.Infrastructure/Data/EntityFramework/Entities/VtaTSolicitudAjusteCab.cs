using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTSolicitudAjusteCab
{
    public decimal SolicitudAjusteCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public byte SacTipoSolicitud { get; set; }

    public int SacNumDocto { get; set; }

    public DateTime FechaDocumento { get; set; }

    public DateTime SacFecVecto { get; set; }

    public byte SacAsociaDocto { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public byte SacIndAnula { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public decimal PVendedorId { get; set; }

    public decimal PVendedorDigitaId { get; set; }

    public byte TpdTipoParidad { get; set; }

    public double DvcValorParidad { get; set; }

    public DateTime FechaParidad { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PNegocioVtaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public string SacObservacion { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public string CodOwner { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PTipoOpeId { get; set; }
}
