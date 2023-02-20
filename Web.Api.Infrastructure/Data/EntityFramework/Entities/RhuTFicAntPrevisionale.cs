using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntPrevisionale
{
    public decimal AntPrevId { get; set; }

    public decimal PFicPerId { get; set; }

    public DateTime PreFecVigencia { get; set; }

    public string PreIndPrevisional { get; set; } = null!;

    public decimal PInsParId { get; set; }

    public decimal PreIndCotizacion { get; set; }

    public byte PreIndJubilado { get; set; }

    public decimal PreItmParPensionId { get; set; }

    public int PreMesesReconocidos { get; set; }

    public int PreMesCotizados { get; set; }

    public DateTime PreFecRecMeses { get; set; }

    public int PreNumGrupoFam { get; set; }

    public int PreNumCargasInv { get; set; }

    public int PreNumCargasNor { get; set; }

    public int PreNumCargasEst { get; set; }

    public int PreNumCargasCorr { get; set; }

    public int PreNumCargasEsp { get; set; }

    public decimal PTramoId { get; set; }

    public decimal PAntAfpId { get; set; }

    public decimal PAntSaludId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string TraCodTramo { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;
}
