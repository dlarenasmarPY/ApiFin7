using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TesTDetalleEmi
{
    public decimal PCabEmiId { get; set; }

    public decimal PMovCceId { get; set; }

    public decimal PMovTesId { get; set; }

    public decimal PCabOpeId { get; set; }

    public byte SisCodOri { get; set; }
}
