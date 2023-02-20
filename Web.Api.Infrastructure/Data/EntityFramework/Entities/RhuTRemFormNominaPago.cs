using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemFormNominaPago
{
    public byte FormNomPagoCod { get; set; }

    public string FormNomPagoDes { get; set; } = null!;
}
