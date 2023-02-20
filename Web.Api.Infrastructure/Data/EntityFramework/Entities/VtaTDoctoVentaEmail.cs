using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTDoctoVentaEmail
{
    public decimal EmailAdressNpid { get; set; }

    public decimal PDoctoVentaCabId { get; set; }

    public string EmailAddress { get; set; } = null!;
}
