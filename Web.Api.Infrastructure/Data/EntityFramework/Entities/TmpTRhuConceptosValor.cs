using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuConceptosValor
{
    public decimal TmpConcConVal { get; set; }

    public string CodOwner { get; set; } = null!;

    public decimal PTmpConcCon { get; set; }

    public decimal PLiqId { get; set; }

    public decimal PConcRemId { get; set; }

    public decimal PItmGruConId { get; set; }

    public decimal PEntId { get; set; }

    public string EntRut { get; set; } = null!;

    public decimal PCtoId { get; set; }

    public decimal PMonedaId { get; set; }

    public double Monto { get; set; }

    public decimal EntId2 { get; set; }

    public string Rut { get; set; } = null!;

    public decimal PCreId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal LqDorigenMov { get; set; }

    public decimal LqDrefOrigenId { get; set; }

    public decimal PAntPrevId { get; set; }

    public decimal PAntAfpId { get; set; }

    public decimal PAntSaludId { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public decimal PLiqTotId { get; set; }

    public decimal PliqDetId { get; set; }

    public decimal PDocCceId { get; set; }

    public short MovCceNumCuota { get; set; }
}
