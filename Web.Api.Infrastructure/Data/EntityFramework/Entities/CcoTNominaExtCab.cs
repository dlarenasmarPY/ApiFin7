using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTNominaExtCab
{
    public decimal CabNomExtId { get; set; }

    public byte TipNomCod { get; set; }

    public int CabNomExtNumNomina { get; set; }

    public DateTime CabNomExtFecNomina { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PEntCcoId { get; set; }

    public byte CabNomExtEstado { get; set; }

    public DateTime CabNomExtFecEstado { get; set; }

    public string CabNomExtOwner { get; set; } = null!;

    public byte ModCcoCod { get; set; }

    public byte InsCcoCod { get; set; }

    public short TdoAgrupaCod { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCabOpeId { get; set; }

    public decimal PCabOpeIdReversa { get; set; }

    public DateTime CabNomExtFechaReversa { get; set; }

    public DateTime CabNomExtFechaEnvio { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
