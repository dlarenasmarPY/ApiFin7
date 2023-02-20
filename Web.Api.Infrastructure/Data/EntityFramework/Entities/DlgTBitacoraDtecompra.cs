using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTBitacoraDtecompra
{
    public decimal BdtId { get; set; }

    public decimal PRecepcionDetId { get; set; }

    public decimal PLlgDocId { get; set; }

    public string IdUsuario { get; set; } = null!;

    public DateTime BdtFecha { get; set; }

    public string BdtDescripcion { get; set; } = null!;

    public byte BdtConEstCodAntiguo { get; set; }

    public byte BdtConEstCodNuevo { get; set; }

    public decimal PReglaRecepCabId { get; set; }

    public string IdFuncionUltModifReg { get; set; } = null!;
}
