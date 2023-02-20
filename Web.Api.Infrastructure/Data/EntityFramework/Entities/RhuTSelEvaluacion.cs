using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelEvaluacion
{
    public decimal IdEvaluacion { get; set; }

    public short CgoCodCargo { get; set; }

    public decimal PEmpId { get; set; }

    public string TipoEstado { get; set; } = null!;

    public string IndFormulario { get; set; } = null!;

    public decimal PItmEvaluacion { get; set; }

    public string CodFormulario { get; set; } = null!;

    public int PorCalificacionMax { get; set; }

    public int PorCalificacionMin { get; set; }

    public short CantDiasMaximo { get; set; }

    public string IndProgramacionMasiva { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParCargo CgoCodCargoNavigation { get; set; } = null!;

    public virtual ICollection<RhuTSelEvaluaPostulante> RhuTSelEvaluaPostulantes { get; } = new List<RhuTSelEvaluaPostulante>();
}
