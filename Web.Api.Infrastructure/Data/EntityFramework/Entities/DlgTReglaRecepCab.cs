using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTReglaRecepCab
{
    public decimal ReglaRecepCabId { get; set; }

    public decimal PEmpId { get; set; }

    public string RrcGlosa { get; set; } = null!;

    public decimal PTdoReferenciaSiiId { get; set; }

    public byte RrcIndProcesoExito { get; set; }

    public byte RrcIndProcesoNoExito { get; set; }

    public byte RrcIndDesglose { get; set; }

    public short RrgCodigo { get; set; }

    public short RrvCodigo { get; set; }

    public DateTime RrcFecVigencia { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public byte RrcIndDefecto { get; set; }

    public byte RrcIndNivVal { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
