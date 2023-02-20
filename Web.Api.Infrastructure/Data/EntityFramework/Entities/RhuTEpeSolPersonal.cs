using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEpeSolPersonal
{
    public decimal EpeSolFicId { get; set; }

    public decimal PEpeSolId { get; set; }

    public byte EpeTipoCambio { get; set; }

    public string EpeDirFono { get; set; } = null!;

    public string EpeCelular { get; set; } = null!;

    public string EpeDirFax { get; set; } = null!;

    public string EpeEmail { get; set; } = null!;

    public decimal PEpeItmProfId { get; set; }

    public string EpeDirDireccion { get; set; } = null!;

    public int CmuCodigo { get; set; }

    public int CiuCodigo { get; set; }

    public decimal PFormaPagoId { get; set; }

    public int InstCod { get; set; }

    public short EpeSucInstSuc { get; set; }

    public string EpeSucCodCtaCteBco { get; set; } = null!;

    public DateTime EpeFecNacimiento { get; set; }

    public decimal EpeCmuCodigo { get; set; }

    public decimal PItmEpeNacionId { get; set; }

    public byte EpeSitMil { get; set; }

    public short EpeInscripcion { get; set; }

    public string EpeCanton { get; set; } = null!;

    public byte EpeCalzado { get; set; }

    public byte EpeTalla { get; set; }

    public byte EpeCasaca { get; set; }

    public byte EpePeso { get; set; }

    public int EpeCmuEleCodigo { get; set; }

    public string EpeMotivo { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParItem PEpeItmProf { get; set; } = null!;

    public virtual RhuTEpeSolicitude PEpeSol { get; set; } = null!;
}
