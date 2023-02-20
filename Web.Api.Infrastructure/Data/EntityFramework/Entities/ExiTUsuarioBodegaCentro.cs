using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTUsuarioBodegaCentro
{
    public string FldUserCode { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PCconsumoId { get; set; }

    public decimal PBodegaIdDefault { get; set; }

    public decimal PCconsumoIdDefault { get; set; }
}
