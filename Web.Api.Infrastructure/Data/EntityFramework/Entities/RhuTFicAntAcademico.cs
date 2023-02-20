using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntAcademico
{
    public decimal AntAdedId { get; set; }

    public decimal PFicPerId { get; set; }

    public DateTime AdeFecInicio { get; set; }

    public DateTime AdeFecTermino { get; set; }

    public decimal PItmCarreraId { get; set; }

    public string AdeCodCursoHom { get; set; } = null!;

    public decimal PItmNivEducId { get; set; }

    public decimal PItmTituloId { get; set; }

    public decimal PItmInstEducId { get; set; }

    public string AdeTexto { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmCarrera { get; set; } = null!;

    public virtual RhuTParItem PItmInstEduc { get; set; } = null!;

    public virtual RhuTParItem PItmNivEduc { get; set; } = null!;

    public virtual RhuTParItem PItmTitulo { get; set; } = null!;
}
