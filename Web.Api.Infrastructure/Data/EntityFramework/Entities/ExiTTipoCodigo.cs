using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTTipoCodigo
{
    public decimal TipoCodigoId { get; set; }

    public string TipoCodigoCod { get; set; } = null!;

    public string TipoCodigoDes { get; set; } = null!;

    public byte TipoCodigoEntidad { get; set; }

    public byte TipoCodigoUtiliza { get; set; }

    public byte TipoCodigoSecuencia { get; set; }

    public virtual ICollection<ExiTProductosCodigo> ExiTProductosCodigos { get; } = new List<ExiTProductosCodigo>();
}
