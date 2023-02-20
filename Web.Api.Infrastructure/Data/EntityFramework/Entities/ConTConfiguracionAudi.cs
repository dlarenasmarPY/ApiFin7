using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTConfiguracionAudi
{
    public decimal ConConfigAuid { get; set; }

    public DateTime EntAudFechaMod { get; set; }

    public string EntAudUsuario { get; set; } = null!;

    public string EntAudAccion { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public byte SisCodOri { get; set; }

    public decimal PMonedaId { get; set; }

    public DateTime CfgConFechaMinimaImp { get; set; }

    public DateTime CfgConFechaMaximaImp { get; set; }

    public int CfgConDifMaxCompCont { get; set; }

    public decimal CfgConCuentaContDif { get; set; }

    public bool CfgConEstadoEjercicio { get; set; }

    public short PerIdCorMon { get; set; }

    public decimal PPciId { get; set; }

    public decimal MonCodigoConv { get; set; }

    public string CfgGlosaConv { get; set; } = null!;

    public byte CfgUsoCorrelativo { get; set; }

    public byte CfgUsoContabilizacion { get; set; }

    public byte CfgIndUsaCorrDiv { get; set; }

    public short CfgConMaxRegistros { get; set; }

    public byte CfgConLectorCheque { get; set; }

    public short CfgConDivCodigo { get; set; }

    public short CfgConUniCodigo { get; set; }

    public string CfgPathArchivoCheques { get; set; } = null!;

    public decimal CfgTipoOpeIdIntDiv { get; set; }

    public decimal CfgCtaIdInter { get; set; }

    public decimal CfgCtaIdInterFlujo { get; set; }

    public int CfgConDifMaxCompConv { get; set; }

    public decimal CfgConCuentaConvDif { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
