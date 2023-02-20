using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemAntPrevConsultum
{
    public string CodOwner { get; set; } = null!;

    public string PreIndPrevisional { get; set; } = null!;

    public decimal PFicPerId { get; set; }

    public decimal PInsParId { get; set; }

    public decimal? PAntSaludId { get; set; }

    public decimal? PAntAfpId { get; set; }

    public byte? CtoIndSegCes { get; set; }
}
