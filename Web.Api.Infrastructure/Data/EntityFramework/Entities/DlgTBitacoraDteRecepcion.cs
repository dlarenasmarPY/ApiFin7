using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTBitacoraDteRecepcion
{
    public decimal RecepcionDetId { get; set; }

    public decimal PEmpId { get; set; }

    public string RecDetRutEmisor { get; set; } = null!;

    public string RecDetRutReceptor { get; set; } = null!;

    public int DlcFolioDocto { get; set; }

    public short TdoSii { get; set; }

    public DateTime RecFechaEmision { get; set; }

    public double RecMontoTotal { get; set; }

    public byte RecDetEstado { get; set; }

    public DateTime RecDetFechaRecepcion { get; set; }

    public string RecDetXml { get; set; } = null!;

    public string RecDetError { get; set; } = null!;

    public string RecNombreArchivo { get; set; } = null!;

    public byte TipoXmlDte { get; set; }

    public DateTime FecIngReg { get; set; }

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PRecepcionCabId { get; set; }

    public string Email { get; set; } = null!;
}
