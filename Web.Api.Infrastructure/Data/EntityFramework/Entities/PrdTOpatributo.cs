using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOpatributo
{
    public decimal OpatributoId { get; set; }

    public decimal POpcabId { get; set; }

    public decimal POpdetId { get; set; }

    public decimal PForAtributoId { get; set; }

    public decimal PAtributoId { get; set; }

    public string AtributoValor { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
