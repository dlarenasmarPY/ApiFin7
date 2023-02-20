using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTPlanBiene
{
    public decimal PdAfiId { get; set; }

    public string PdAfiNomPlan { get; set; } = null!;

    public byte PdAfiCantidadNiveles { get; set; }

    public string PdAfiNomNivel1 { get; set; } = null!;

    public string PdAfiNomNivel2 { get; set; } = null!;

    public string PdAfiNomNivel3 { get; set; } = null!;

    public string PdAfiNomNivel4 { get; set; } = null!;

    public string PdAfiNomNivel5 { get; set; } = null!;

    public string PdAfiNomNivel6 { get; set; } = null!;

    public string PdAfiNomNivel7 { get; set; } = null!;

    public string PdAfiOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
