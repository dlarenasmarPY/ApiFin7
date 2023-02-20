using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTGlosa
{
    public decimal GlosaId { get; set; }

    public string GlosaDes { get; set; } = null!;

    public byte IndTipoGlosa { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<AdqTCotizacionCabGlosa> AdqTCotizacionCabGlosas { get; } = new List<AdqTCotizacionCabGlosa>();

    public virtual ICollection<AdqTCotizacionDetGlosa> AdqTCotizacionDetGlosas { get; } = new List<AdqTCotizacionDetGlosa>();

    public virtual ICollection<AdqTOcCabGlosa> AdqTOcCabGlosas { get; } = new List<AdqTOcCabGlosa>();

    public virtual ICollection<AdqTOcDetGlosa> AdqTOcDetGlosas { get; } = new List<AdqTOcDetGlosa>();
}
