using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntComplementario
{
    public decimal AntPleId { get; set; }

    public decimal PFicPerId { get; set; }

    public byte PleSitMil { get; set; }

    public short PleInscripcion { get; set; }

    public int CmuCodigo { get; set; }

    public string PleCanton { get; set; } = null!;

    public byte PleCalzado { get; set; }

    public byte PlePeso { get; set; }

    public byte PleTalla { get; set; }

    public byte PleCasaca { get; set; }

    public decimal PItmViviendaId { get; set; }

    public byte PleIndMovil { get; set; }

    public byte PleIndIngresos { get; set; }

    public string PleObservacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmVivienda { get; set; } = null!;
}
