using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTSolicitudEmiDoc
{
    public decimal SolDocId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public byte TipNomCod { get; set; }

    public int SolDocNumSolicitud { get; set; }

    public DateTime SolDocFecSolicitud { get; set; }

    public byte SisCodOri { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PEntIdSec { get; set; }

    public short EntSucNumeroSec { get; set; }

    public string DocCceDocRef { get; set; } = null!;

    public byte SolDocEstado { get; set; }

    public DateTime SolDocFecEstado { get; set; }

    public short TdoId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PorExento { get; set; }

    public string SolDocOwner { get; set; } = null!;

    public decimal PRenCabId { get; set; }

    public decimal PCabOpeId { get; set; }

    public decimal PCabOpeIdReversa { get; set; }

    public DateTime SolDocFecReversa { get; set; }

    public byte SolDocGen { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
