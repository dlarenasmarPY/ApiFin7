using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosResp29032017
{
    public decimal ProductoId { get; set; }

    public string ProductoCod { get; set; } = null!;

    public string ProductoDes { get; set; } = null!;

    public string ProductoDesTec { get; set; } = null!;

    public decimal PUnidadMedId { get; set; }

    public decimal PUnidadMed2Id { get; set; }

    public decimal PCategoriaId { get; set; }

    public byte IndicaSerie { get; set; }

    public byte TipoSerie { get; set; }

    public byte IndicaLote { get; set; }

    public byte IndControlCalidad { get; set; }

    public byte IndReceta { get; set; }

    public DateTime FechaVigencia { get; set; }

    public byte IndKit { get; set; }

    public byte IndKitPre { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte IndValorizaLote { get; set; }

    public decimal PMarcaId { get; set; }

    public byte IndAbastecimiento { get; set; }

    public byte IndAfectoVnr { get; set; }

    public double ValorRealizacion { get; set; }

    public decimal PMonedaId { get; set; }

    public short AfiGrupoCod { get; set; }

    public short AfiSubGrpCod { get; set; }

    public byte IndPallets { get; set; }

    public decimal PEntId { get; set; }

    public int UnidadesxCaja { get; set; }

    public byte IntWms { get; set; }

    public byte Intangible { get; set; }
}
