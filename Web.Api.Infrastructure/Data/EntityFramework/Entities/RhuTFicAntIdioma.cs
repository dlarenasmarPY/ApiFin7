using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntIdioma
{
    public decimal AntIdiomaId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PItmIdiomaId { get; set; }

    public decimal PItmIdiLecId { get; set; }

    public decimal PItmIdiEscId { get; set; }

    public decimal PItmIdiHabId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmIdiEsc { get; set; } = null!;

    public virtual RhuTParItem PItmIdiHab { get; set; } = null!;

    public virtual RhuTParItem PItmIdiLec { get; set; } = null!;

    public virtual RhuTParItem PItmIdioma { get; set; } = null!;
}
