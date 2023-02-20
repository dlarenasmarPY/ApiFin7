using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTCertificado
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public decimal PEntId { get; set; }

    public int CerNumero { get; set; }

    public double CerMtoRetenidoNom { get; set; }

    public double CerMtoRetenidoAct { get; set; }

    public string CerOwner { get; set; } = null!;
}
