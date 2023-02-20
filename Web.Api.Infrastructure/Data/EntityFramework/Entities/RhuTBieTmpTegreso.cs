using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTBieTmpTegreso
{
    public string CodOwner { get; set; } = null!;

    public short EjeAno { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PBieSolId { get; set; }

    public DateTime FecSolicitud { get; set; }

    public decimal PBeneficiosId { get; set; }

    public decimal CodBeneficio { get; set; }

    public decimal PBieSocId { get; set; }

    public string EntRut { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public decimal ValAprobado { get; set; }
}
