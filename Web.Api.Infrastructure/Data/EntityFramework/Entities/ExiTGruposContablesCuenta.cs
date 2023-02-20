using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTGruposContablesCuenta
{
    public decimal GrupoContCuentaId { get; set; }

    public decimal PGrupoContId { get; set; }

    public byte SituacionContCod { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PEntId { get; set; }

    public byte IndActivoFijo { get; set; }

    public virtual ExiTGruposContable PGrupoCont { get; set; } = null!;

    public virtual LogTSituacionContable SituacionContCodNavigation { get; set; } = null!;
}
