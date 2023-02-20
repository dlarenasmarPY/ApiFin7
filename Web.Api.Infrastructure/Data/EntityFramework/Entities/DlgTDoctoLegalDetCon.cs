using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalDetCon
{
    public decimal DoctoLegalDetConId { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public decimal PDoctoLegalDetId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public double DlaPorcentaje { get; set; }

    public double DlaMtoDistribuido { get; set; }

    public double DlaMtoDistribuidoLocal { get; set; }

    public double DlaMtoDistribuidoConv { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
