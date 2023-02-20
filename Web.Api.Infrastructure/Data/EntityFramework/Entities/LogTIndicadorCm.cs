using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTIndicadorCm
{
    public decimal IndCmid { get; set; }

    public byte IndCmcod { get; set; }

    public string IndCmdes { get; set; } = null!;
}
