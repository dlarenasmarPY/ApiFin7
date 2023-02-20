using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class EfeTEstConciliacion
{
    public decimal PEmpId { get; set; }

    public decimal EfeFlujoEstConcCod { get; set; }

    public string EfeFlujoEstConcDes { get; set; } = null!;

    public decimal EfeFlujoAplicaCm { get; set; }

    public decimal EfeFlujoGenInforme { get; set; }

    public string EfeFlujoFormula { get; set; } = null!;
}
