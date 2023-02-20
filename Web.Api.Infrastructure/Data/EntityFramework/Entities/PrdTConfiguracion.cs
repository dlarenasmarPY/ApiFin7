using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTConfiguracion
{
    public decimal ConfiguracionId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public byte IndBodegaProceso { get; set; }

    public decimal PTipoOpeIdPrdPed { get; set; }

    public decimal PTipoOpeIdPrdTra { get; set; }

    public decimal PTipoOpeIdPrdEnt { get; set; }

    public decimal PTipoOpeIdPrdAjuEnt { get; set; }

    public decimal PTipoOpeIdPrdAjuSal { get; set; }

    public short TdoIdPed { get; set; }

    public short TdoIdTra { get; set; }

    public byte IndImpRecOp { get; set; }

    public byte IndPrdAjuste { get; set; }

    public decimal PctaPrdTribId { get; set; }

    public decimal PcctaPrdTribId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte IndAprEntrega { get; set; }

    public decimal? PTipoOpeIdPrdDev { get; set; }

    public decimal PTipoOpeIdOpeExt { get; set; }

    public decimal PTipoOpeIdPrdCub { get; set; }

    public decimal PUnidadMed2Id { get; set; }

    public byte ValidaCantidadSol { get; set; }

    public byte RealizaConsumos { get; set; }

    public short? IndicaProcesoMaquila { get; set; }

    public short? IndicaProcesoMaquilaAtl { get; set; }

    public decimal MaqTipoOp { get; set; }

    public decimal MaqSeccionId { get; set; }

    public decimal MaqBodegaIdConsumo { get; set; }

    public decimal MaqTipoOpeIdConsumo { get; set; }

    public decimal MaqMaquinaId { get; set; }

    public byte ValidaCantEnt { get; set; }

    public int PTipoOpeDevConsumo { get; set; }

    public decimal PTipoOpeTraspasoOp { get; set; }

    public int ValidaAsigConsumos { get; set; }

    public int? CantOpinfVta { get; set; }

    public byte ValidaCostoEstandar { get; set; }
}
