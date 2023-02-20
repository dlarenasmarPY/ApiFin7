using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemDistribucion
{
    public decimal DccId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PPerId { get; set; }

    public short PerIdFinal { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PCreId { get; set; }

    public decimal PorcentajeDist { get; set; }
}
