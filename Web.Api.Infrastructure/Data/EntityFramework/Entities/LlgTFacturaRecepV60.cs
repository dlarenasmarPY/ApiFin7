using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTFacturaRecepV60
{
    public decimal FactRecepId { get; set; }

    public decimal PCabLlgId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int CodigoBodega { get; set; }

    public byte TipoTransaccion { get; set; }

    public int EmbNumId { get; set; }

    public int RecNumId { get; set; }

    public int RecDetLinea { get; set; }

    public int OrdNumId { get; set; }

    public short TotItemLinea { get; set; }

    public short TdoId { get; set; }

    public string CodigoArticulo { get; set; } = null!;

    public double RecDetCantDesp { get; set; }

    public double RecDetCantRec { get; set; }

    public double RecDetCantRech { get; set; }

    public double RecDetCantAcep { get; set; }

    public double ValorMonedaCompra { get; set; }

    public double ValorFinal { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public int Linea { get; set; }

    public byte TipoUbl { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
