using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTBitacoraDte
{
    public decimal BdtId { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public string IdUsuario { get; set; } = null!;

    public DateTime BdtFecha { get; set; }

    public string BdtDescripcion { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte BdtConEstCodAntiguo { get; set; }

    public byte BdtConEstCodNuevo { get; set; }
}
