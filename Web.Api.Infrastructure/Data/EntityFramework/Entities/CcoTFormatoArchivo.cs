using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTFormatoArchivo
{
    public decimal FrmCcoId { get; set; }

    public decimal PEntCcoId { get; set; }

    public string FrmFormato { get; set; } = null!;

    public byte TipNomCod { get; set; }

    public byte FrmCcoIndEnvRec { get; set; }

    public byte FrmTipoArchivo { get; set; }

    public byte FrmTipoFormato { get; set; }

    public string FrmSeparador { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
