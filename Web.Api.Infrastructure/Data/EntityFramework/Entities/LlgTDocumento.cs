using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTDocumento
{
    public decimal LlgDocId { get; set; }

    public decimal PEmpId { get; set; }

    public DateTime LlgDocFechaIng { get; set; }

    public short PerId { get; set; }

    public int LlgDocNumInterno { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public short TdoId { get; set; }

    public string LlgDocNumDoc { get; set; } = null!;

    public int LlgDocNumProvision { get; set; }

    public DateTime LlgDocFecha { get; set; }

    public DateTime LlgDocFechaVenc { get; set; }

    public byte LlgDocEstado { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal LlgDocMtoImpuAfecto { get; set; }

    public decimal LlgDocMtoImpuNeto { get; set; }

    public decimal LlgDocMtoImpuExento { get; set; }

    public decimal LlgDocMtoImpuIva { get; set; }

    public decimal LlgDocMtoImpuOtrosImp { get; set; }

    public decimal LlgDocMtoImpuDerAdu { get; set; }

    public decimal LlgDocMtoImpuRete { get; set; }

    public decimal LlgDocMtoImpuTotal { get; set; }

    public decimal LlgDocMtoLocalTotal { get; set; }

    public decimal LlgDocMtoTotalNeto { get; set; }

    public decimal LlgDocMtoIvaRec100 { get; set; }

    public decimal LlgDocMtoIvaRecPro { get; set; }

    public decimal LlgDocMtoIvaNoRec { get; set; }

    public DateTime LlgDocFechaReversa { get; set; }

    public decimal LlgIdReversa { get; set; }

    public string LlgDocDigUsuario { get; set; } = null!;

    public DateTime LlgDocDigFecha { get; set; }

    public string LlgDocActUsuario { get; set; } = null!;

    public DateTime LlgDocActFecha { get; set; }

    public string LlgDocAprUsuario { get; set; } = null!;

    public DateTime LlgDocAprFecha { get; set; }

    public string LlgDocOwner { get; set; } = null!;

    public string LlgDocGlosa { get; set; } = null!;

    public byte TipFactId { get; set; }

    public byte OrigenArticulo { get; set; }

    public short TipOriDoctoCod { get; set; }

    public byte DlcEstadoDte { get; set; }

    public short DteId { get; set; }

    public byte LibTipo { get; set; }

    public int LibNumero { get; set; }

    public string TipoEnvio { get; set; } = null!;

    public string FelError { get; set; } = null!;

    public string FelTipo { get; set; } = null!;

    public byte SisCodOri { get; set; }

    public decimal PCreId { get; set; }

    public byte Llg4taCopiaCedible { get; set; }
}
