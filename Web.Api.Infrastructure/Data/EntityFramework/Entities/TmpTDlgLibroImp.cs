using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTDlgLibroImp
{
    public decimal PLibLibroCvid { get; set; }

    public byte LibCodIvaNoRecuperable { get; set; }

    public double MtoIvaNoRecuperable { get; set; }

    public int LibCodImptoReten { get; set; }

    public double LibTasaImptoReten { get; set; }

    public double MtoImptoReten { get; set; }
}
