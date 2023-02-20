using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTInterfazEntidade
{
    public decimal IntIntId { get; set; }

    public string IntTmpOwner { get; set; } = null!;

    public byte IndTransaccion { get; set; }

    public string EntRut { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public string EntNomFantasia { get; set; } = null!;

    public DateTime EntFecActivacion { get; set; }

    public byte EntTipoSociedadCod { get; set; }

    public int GirCod { get; set; }

    public int AecCod { get; set; }

    public byte EntProcedencia { get; set; }

    public byte EstEntCod { get; set; }

    public byte NivId { get; set; }

    public string EntRutHolding { get; set; } = null!;

    public string EntSitioWeb { get; set; } = null!;

    public byte EntTipoRazonSocial { get; set; }

    public byte EntTipoCategoria { get; set; }

    public string EntDirDireccion { get; set; } = null!;

    public int CmuCodigo { get; set; }

    public int CiuCodigo { get; set; }

    public string EntDirFono { get; set; } = null!;

    public string EntDirFax { get; set; } = null!;

    public string EntDirCodPostal { get; set; } = null!;

    public byte ProcesoCod { get; set; }

    public short XEntSucNumero { get; set; }

    public string EntConNombres { get; set; } = null!;

    public string EntConApePaterno { get; set; } = null!;

    public string EntConApeMaterno { get; set; } = null!;

    public string EntConSexo { get; set; } = null!;

    public string EntConGlosaCargo { get; set; } = null!;

    public string EntConMail { get; set; } = null!;

    public short EntSucNumero { get; set; }

    public string EntSucDescripcion { get; set; } = null!;

    public decimal PFormaPagoId { get; set; }

    public byte FormaPagoCheque { get; set; }

    public byte IndCruzado { get; set; }

    public int InstCod { get; set; }

    public short EntSucInstSuc { get; set; }

    public string EntSucCodCtaCteBco { get; set; } = null!;
}
