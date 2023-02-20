using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTDocumento
{
    public short TdoId { get; set; }

    public string TdoGlosa { get; set; } = null!;

    public string TdoNomCorto { get; set; } = null!;

    public byte TdoVigencia { get; set; }

    public short TdoAgrupaCod { get; set; }

    public virtual ICollection<AdqTClausulaCompraDocto> AdqTClausulaCompraDoctos { get; } = new List<AdqTClausulaCompraDocto>();

    public virtual ICollection<CceTDocumento> CceTDocumentos { get; } = new List<CceTDocumento>();
}
