using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTBitacora
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public int CarOfeNumInterno { get; set; }

    public decimal PTprId { get; set; }

    public DateTime Fecha { get; set; }

    public byte InstPvtaId { get; set; }

    public int Secuencia { get; set; }

    public byte DocEstado { get; set; }

    public string UserInstancia { get; set; } = null!;

    public string FldUserCode { get; set; } = null!;

    public short UniCodigo { get; set; }

    public string ObsGlosa { get; set; } = null!;

    public byte InstProxima { get; set; }

    public DateTime FechaProxInst { get; set; }

    public short DiasProxInst { get; set; }

    public DateTime FechaIniProg { get; set; }

    public DateTime FechaFinProg { get; set; }

    public DateTime FechaReal { get; set; }

    public int TipoRegistro { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
