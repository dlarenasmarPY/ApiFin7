using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTParCtasConfig
{
    public decimal PEmpId { get; set; }

    public int XCtaCodigo { get; set; }

    public byte XCtaUsaCentroResp { get; set; }

    public byte XCtaUsaConcepto { get; set; }

    public byte XCtaUsaProyecto { get; set; }
}
