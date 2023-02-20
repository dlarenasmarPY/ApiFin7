using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTRecepcionResp
{
    public decimal RecepcionRespId { get; set; }

    public decimal PEmpId { get; set; }

    public string RecResRutEmisor { get; set; } = null!;

    public byte RecResIndEnviada { get; set; }

    public int RecResNroDtes { get; set; }

    public decimal PEntIdFirma { get; set; }

    public DateTime RecResFecFirma { get; set; }

    public DateTime RecResFecEnvia { get; set; }

    public string RecResXml { get; set; } = null!;
}
