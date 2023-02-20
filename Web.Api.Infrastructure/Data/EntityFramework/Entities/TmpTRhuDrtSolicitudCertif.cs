using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuDrtSolicitudCertif
{
    public string CodOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public decimal PFicPerId { get; set; }
}
