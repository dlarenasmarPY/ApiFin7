using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTInstancia
{
    public byte InstPvtaId { get; set; }

    public string InstGlosa { get; set; } = null!;

    public double PorcComision { get; set; }

    public byte IndHito { get; set; }

    public byte HitoAnterior { get; set; }

    public byte HitoPosterior { get; set; }

    public byte ProcId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<InmTInstanciaVentum> InmTInstanciaVenta { get; } = new List<InmTInstanciaVentum>();
}
