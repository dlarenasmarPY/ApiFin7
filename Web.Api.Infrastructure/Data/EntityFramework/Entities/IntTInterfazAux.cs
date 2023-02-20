using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTInterfazAux
{
    public decimal IntIntId { get; set; }

    public string IntTmpOwner { get; set; } = null!;

    public byte SisCodOri { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string IntBitArchivo { get; set; } = null!;

    public DateTime CabOpeFecha { get; set; }

    public int IntPeriodo { get; set; }

    public short OpeCod { get; set; }

    public string CabOpeGlosa { get; set; } = null!;

    public int CabOpeNumero { get; set; }

    public int CabOpeLinea { get; set; }

    public int CtaCodigo { get; set; }

    public string MovCceGlosa { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public int CreCodigo { get; set; }

    public int CdiCodigo { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public string LineaProdCodigo { get; set; } = null!;

    public string EntRut { get; set; } = null!;

    public short EntSucNumero { get; set; }

    public string EntRutSec { get; set; } = null!;

    public short EntSucNumeroSec { get; set; }

    public string EntRutTer { get; set; } = null!;

    public short EntSucNumeroTer { get; set; }

    public short TdoId { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public DateTime DocCceFecEmi { get; set; }

    public short MovCceNumCuota { get; set; }

    public DateTime MovCceFecVenc { get; set; }

    public DateTime DocCceFecProyectada { get; set; }

    public double MovCceMontoImpuDebe { get; set; }

    public double MovCceMontoImpuHaber { get; set; }

    public double MovCceMontoLocalDebe { get; set; }

    public double MovCceMontoLocalHaber { get; set; }

    public int InstCod { get; set; }

    public int PlaCod { get; set; }

    public string RutBeneficiario { get; set; } = null!;

    public decimal PFormaPagoId { get; set; }

    public short UniCodigoEmi { get; set; }

    public DateTime MovCceFecPagoPropuesta { get; set; }

    public short ClcId { get; set; }

    public decimal PCabReferenciaId { get; set; }

    public decimal PDetReferenciaId { get; set; }

    public string MovCcePeriodo { get; set; } = null!;

    public string CodCtaCteBco { get; set; } = null!;

    public byte IntError { get; set; }

    public decimal CtoNumero { get; set; }

    public short ConCcpCod { get; set; }

    public double MovCceMontoConvDebe { get; set; }

    public double MovCceMontoConvHaber { get; set; }
}
