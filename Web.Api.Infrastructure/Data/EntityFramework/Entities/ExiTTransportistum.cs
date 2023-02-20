using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTTransportistum
{
    public decimal TranspId { get; set; }

    public decimal POpeLogtCabId { get; set; }

    public short TdoId { get; set; }

    public int DlcFolioDocto { get; set; }

    public decimal PEntId { get; set; }

    public decimal PTipoVehId { get; set; }

    public string TranspPatente { get; set; } = null!;

    public string TranspChofer { get; set; } = null!;

    public string GlosaExis { get; set; } = null!;

    public string ExiOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
