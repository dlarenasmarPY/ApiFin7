using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoDatosCertif
{
    public decimal DtoDatId { get; set; }

    public decimal PDtoTipId { get; set; }

    public decimal PDtoDicId { get; set; }

    public string DtoDatFiltro { get; set; } = null!;

    public byte DtoDicUsoFiltro { get; set; }

    public string DtoDicNomCol { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public virtual RhuTParDiccionario PDtoDic { get; set; } = null!;

    public virtual RhuTCtoTipoCertif PDtoTip { get; set; } = null!;
}
