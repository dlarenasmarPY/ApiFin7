using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTConceptoImportacion
{
    public decimal ConceptoImpId { get; set; }

    public string ConceptoImpGlosa { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public byte IndContabilizaConcepto { get; set; }

    public byte IndAfectaCostoConcepto { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PCctaId { get; set; }

    public decimal PCcreId { get; set; }

    public decimal PCcdiId { get; set; }

    public decimal PCtprId { get; set; }

    public string PryNumeroCtaCta { get; set; } = null!;

    public decimal PPartidaId { get; set; }

    public decimal PTipoConceptoImpId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public short TipoDocRel { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
