using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTFolioElectronico
{
    public decimal FolioElectronicoId { get; set; }

    public decimal PEmpId { get; set; }

    public short TdoSii { get; set; }

    public int FoeFolioInicial { get; set; }

    public int FoeFolioFinal { get; set; }

    public int FoeFolioActual { get; set; }

    public DateTime FoeFecRecepcion { get; set; }

    public string FoeLlavePrivada { get; set; } = null!;

    public string FoeLlavePublica { get; set; } = null!;

    public string FoeXmlCaf { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
