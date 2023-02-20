using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTBitacoraManejoIvaDet
{
    public int PBitacoraId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PTprId { get; set; }

    public int NroBitacora { get; set; }

    public decimal PinmuebleId { get; set; }

    public double M2legalesOri { get; set; }

    public double M2legalesMod { get; set; }
}
