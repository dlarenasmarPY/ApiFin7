using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTCorrNomina
{
    public byte TipNomCod { get; set; }

    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public int CorNomNumInicial { get; set; }

    public int CorNomNumActual { get; set; }
}
