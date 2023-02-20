using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTConfiguracion
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public byte SisCodOri { get; set; }

    public short TcoId { get; set; }

    public double CfgLcoDifMaxIva { get; set; }

    public DateTime CfgLcoFecMinImp { get; set; }

    public DateTime CfgLcoFecMaxImp { get; set; }

    public byte CfgLcoAsigNumProv { get; set; }

    public byte LcoConDistIva { get; set; }

    public bool CfgConfirmaIva { get; set; }

    public byte FlagContable { get; set; }

    public string CerOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
