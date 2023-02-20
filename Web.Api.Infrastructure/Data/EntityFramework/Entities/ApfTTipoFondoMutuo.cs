using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTTipoFondoMutuo
{
    public short TfmCodigo { get; set; }

    public short TafCodigo { get; set; }

    public string TfmNombre { get; set; } = null!;

    public string TfmDescripcion { get; set; } = null!;

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
