using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTBoleta
{
    public decimal BoletaId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string NumeroBoleta { get; set; } = null!;

    public string NumeroPrestamo { get; set; } = null!;

    public byte EstCodigo { get; set; }

    public short TdoId { get; set; }

    public int InstCod { get; set; }

    public string CodCtaCteBco { get; set; } = null!;

    public string GlosaBenef { get; set; } = null!;

    public DateTime FechaVenc { get; set; }

    public DateTime FechaVencAdicional { get; set; }

    public DateTime FechaOtorga { get; set; }

    public decimal PTmatId { get; set; }

    public short TvenCodigo { get; set; }

    public decimal PTlcId { get; set; }

    public decimal PMonedaId { get; set; }

    public double MontoTotal { get; set; }

    public double TasaInteres { get; set; }

    public decimal BeneficiarioEntId { get; set; }

    public short SucBeneficiario { get; set; }

    public decimal TerceroEntId { get; set; }

    public short SucTercero { get; set; }

    public string BolGlosa { get; set; } = null!;

    public string BolDigUsuario { get; set; } = null!;

    public DateTime BolDigFecha { get; set; }

    public string BolAprUsuario { get; set; } = null!;

    public DateTime BolAprFecha { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public short PerId { get; set; }

    public string BolResponsable { get; set; } = null!;

    public string BolActUsuario { get; set; } = null!;

    public DateTime BolActFecha { get; set; }

    public DateTime FechaUltDevengo { get; set; }

    public decimal PCabOpeId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte TipoInteres { get; set; }
}
