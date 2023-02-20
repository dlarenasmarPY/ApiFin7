using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParOrganigrama
{
    public decimal ParOrgId { get; set; }

    public short ParOrgCod { get; set; }

    public string ParOrgDescripcion { get; set; } = null!;

    public decimal PEntId { get; set; }

    public decimal CgoCodCargo { get; set; }

    public string CgoDescripcion { get; set; } = null!;

    public decimal PItmParUniNegId { get; set; }

    public decimal PParOrgSupId { get; set; }

    public string ParOrgImagen { get; set; } = null!;
}
