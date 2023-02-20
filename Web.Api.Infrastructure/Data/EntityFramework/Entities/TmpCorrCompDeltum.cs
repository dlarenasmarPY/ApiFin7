using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpCorrCompDeltum
{
    public decimal Pempid { get; set; }

    public short Perid { get; set; }

    public decimal Pcorid { get; set; }

    public int? MinCorr { get; set; }

    public int? MaxCorr { get; set; }
}
