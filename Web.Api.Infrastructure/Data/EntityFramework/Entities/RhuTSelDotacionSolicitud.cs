using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelDotacionSolicitud
{
    public decimal PidDotacion { get; set; }

    public decimal PidSolicitud { get; set; }

    public DateTime FecSolicitud { get; set; }
}
