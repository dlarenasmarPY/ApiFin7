using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CbaTCartolasPaso
{
    public decimal CarPasoId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int InstCod { get; set; }

    public string CarTmpArchivo { get; set; } = null!;

    public string CarTmpOwner { get; set; } = null!;

    public string IndTipoReg { get; set; } = null!;

    public string CarRegPaso { get; set; } = null!;

    public int Folio { get; set; }
}
