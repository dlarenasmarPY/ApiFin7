using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneFtp
{
    public long Numftp { get; set; }

    public string? Desftp { get; set; }

    public string? Dirftp { get; set; }

    public string? Userna { get; set; }

    public string? Passwo { get; set; }

    public string? Indini { get; set; }

    public string? Indtra { get; set; }

    public string? Indblo { get; set; }

    public string? Cmdini { get; set; }

    public long? Numpue { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public long? Usuact { get; set; }
}
