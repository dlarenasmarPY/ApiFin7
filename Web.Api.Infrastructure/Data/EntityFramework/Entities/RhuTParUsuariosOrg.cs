using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParUsuariosOrg
{
    public decimal UorId { get; set; }

    public string IdUsuario { get; set; } = null!;

    public decimal PEsoId { get; set; }

    public decimal PItmCategoriaId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParEstrOrganica PEso { get; set; } = null!;

    public virtual RhuTParItem PItmCategoria { get; set; } = null!;
}
