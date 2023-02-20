using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTConfiguracion
{
    public decimal CfgPreId { get; set; }

    public decimal PEmpId { get; set; }

    public int CfgNumId { get; set; }

    public string CfgDescripcion { get; set; } = null!;

    public string CfgDescripcionLarga { get; set; } = null!;

    public DateTime CfgFecDig { get; set; }

    public short PerIdInicial { get; set; }

    public short PerIdFinal { get; set; }

    public decimal PPdcId { get; set; }

    public byte PdcNivel { get; set; }

    public bool CfgIndCentro { get; set; }

    public decimal PPcrId { get; set; }

    public bool CfgIndConcepto { get; set; }

    public decimal PPciId { get; set; }

    public bool CfgIndProyecto { get; set; }

    public bool CfgIndFactInt { get; set; }

    public bool CfgIndEmpRel { get; set; }

    public decimal MonCodigo { get; set; }

    public string CfgUsuario { get; set; } = null!;

    public byte CfgEstadoProceso { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public int PeridEmision { get; set; }
}
