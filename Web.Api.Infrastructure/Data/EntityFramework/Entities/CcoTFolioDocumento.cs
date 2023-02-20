using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTFolioDocumento
{
    public decimal FolioDocId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short EjeAno { get; set; }

    public short PerId { get; set; }

    public short TdoAgrupaCod { get; set; }

    public short CorrTalonario { get; set; }

    public string FolioDocGlosa { get; set; } = null!;

    public int FolioInicial { get; set; }

    public int FolioFinal { get; set; }

    public int FolioActual { get; set; }

    public DateTime FecVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
