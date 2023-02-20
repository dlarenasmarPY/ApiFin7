using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ContCabeceraope20170327
{
    public decimal CabOpeId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public byte SisCodOri { get; set; }

    public decimal PTipoOpeId { get; set; }

    public int CabOpeNumero { get; set; }

    public byte ConEstCod { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public DateTime CabOpeFecReversa { get; set; }

    public decimal PCabOpeIdReversa { get; set; }

    public string CabOpeDigUsuario { get; set; } = null!;

    public DateTime CabOpeDigFec { get; set; }

    public string CabOpeActUsuario { get; set; } = null!;

    public DateTime CabOpeActFec { get; set; }

    public string CabOpeAprUsuario { get; set; } = null!;

    public DateTime CabOpeAprFec { get; set; }

    public string CabOpeOwner { get; set; } = null!;

    public string CabOpeGlosa { get; set; } = null!;

    public short CabOpeIdCorrMon { get; set; }

    public bool CabOpeTipoGen { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PEntId { get; set; }

    public int CabOpeLineaActual { get; set; }

    public decimal PCabCompId { get; set; }

    public decimal PCabReferenciaId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
