using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTPasivosFinanciero
{
    public decimal PasDocumentoId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public byte TipoPasivoId { get; set; }

    public byte EstCodigo { get; set; }

    public short TdoId { get; set; }

    public string NumDoctoPasivo { get; set; } = null!;

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal CorredorEntId { get; set; }

    public short Endoso { get; set; }

    public DateTime FechaEmision { get; set; }

    public DateTime FechaVigenciaDesde { get; set; }

    public DateTime FechaVigenciaHasta { get; set; }

    public short IdUso { get; set; }

    public byte RecuperaIva { get; set; }

    public decimal PMonedaId { get; set; }

    public double MontoPresente { get; set; }

    public double TasaInteres { get; set; }

    public double MontoTotal { get; set; }

    public double MontoIva { get; set; }

    public short CantidadCuotas { get; set; }

    public DateTime PrimerVencimiento { get; set; }

    public decimal AseguradoEntId { get; set; }

    public string UbicacionRiesgo { get; set; } = null!;

    public double MontoAsegurado { get; set; }

    public decimal PTmatId { get; set; }

    public string DocGlosaPas { get; set; } = null!;

    public string PasResponsable { get; set; } = null!;

    public decimal TerceroEntId { get; set; }

    public short SucTercero { get; set; }

    public decimal PTlcId { get; set; }

    public short TvenCodigo { get; set; }

    public int InstCod { get; set; }

    public string CodCtaCteBco { get; set; } = null!;

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public short FldGrupo { get; set; }

    public int FldCodBien { get; set; }

    public int FldSecuencia { get; set; }

    public short PerId { get; set; }

    public decimal PCabOpeId { get; set; }

    public byte CuotaFija { get; set; }

    public string PasActUsuario { get; set; } = null!;

    public DateTime PasActFecha { get; set; }

    public DateTime FechaUltDevengo { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte TipoInteres { get; set; }

    public decimal PCodigoBienId { get; set; }

    public int IntIncSeguro { get; set; }
}
