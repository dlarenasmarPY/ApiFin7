using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTBitacora
{
    public decimal BitCcoId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public string BitCcoCobrador { get; set; } = null!;

    public short UniCodigoCbza { get; set; }

    public string BitCcoDigUsuario { get; set; } = null!;

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PEveCcoId { get; set; }

    public DateTime BitCcoFecEvento { get; set; }

    public byte CriCcoCod { get; set; }

    public DateTime BitCcoFecProxEvento { get; set; }

    public decimal PEveCcoIdProxEvento { get; set; }

    public string BitCcoCliGlosa { get; set; } = null!;

    public decimal PDocCceId { get; set; }

    public short MovCceNumCuota { get; set; }

    public decimal PCtaId { get; set; }

    public double BitCcoSaldoImpu { get; set; }

    public double BitCcoSaldoLocal { get; set; }

    public decimal PCabNomId { get; set; }

    public decimal PCabNomIntIdRef { get; set; }

    public byte BitCcoEstado { get; set; }

    public decimal PBitCcoId { get; set; }

    public DateTime BitCcoFecPago { get; set; }

    public decimal PEntConId { get; set; }

    public byte BitCcoHhdesde { get; set; }

    public byte BitCcoMmdesde { get; set; }

    public byte BitCcoHhhasta { get; set; }

    public byte BitCcoMmhasta { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
