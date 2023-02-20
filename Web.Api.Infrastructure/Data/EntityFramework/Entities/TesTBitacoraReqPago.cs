using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TesTBitacoraReqPago
{
    public decimal BitRpid { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public decimal BitRpidentificador { get; set; }

    public DateTime BitRpfecha { get; set; }

    public byte SisCodOri { get; set; }

    public string BitRpglosaCampoMod { get; set; } = null!;

    public double BitRpmontoAntiguo { get; set; }

    public double BitRpmontoNuevo { get; set; }

    public double BitRpsaldoAntiguo { get; set; }

    public double BitRpsaldoNuevo { get; set; }

    public string BitRpglosa { get; set; } = null!;

    public string BitRpusuario { get; set; } = null!;

    public decimal BitRppEntIdAnt { get; set; }

    public decimal BitRppEntIdNue { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
