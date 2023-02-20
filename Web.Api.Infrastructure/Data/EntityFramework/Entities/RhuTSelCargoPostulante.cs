using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelCargoPostulante
{
    public decimal IdCargoPostulante { get; set; }

    public decimal PidPostulante { get; set; }

    public short CgoCodCargo { get; set; }

    public double MontoRentaPostulacion { get; set; }

    public DateTime FecPostulacion { get; set; }

    public decimal PItmExperienciaId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParCargo CgoCodCargoNavigation { get; set; } = null!;

    public virtual RhuTSelPostulante PidPostulanteNavigation { get; set; } = null!;
}
