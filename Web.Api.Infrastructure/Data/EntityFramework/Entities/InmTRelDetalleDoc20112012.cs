using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTRelDetalleDoc20112012
{
    public int EmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public short TesTdoId { get; set; }

    public int TesDocNumInterno { get; set; }

    public int TesDocLinea { get; set; }

    public short ItemFinId { get; set; }

    public short TdoId { get; set; }

    public short CdiIngId { get; set; }
}
