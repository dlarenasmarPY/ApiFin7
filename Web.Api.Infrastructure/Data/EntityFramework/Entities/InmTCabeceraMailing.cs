using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCabeceraMailing
{
    public decimal MailingId { get; set; }

    public DateTime FechaMailing { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PTprId { get; set; }

    public byte RegCodigo { get; set; }

    public int CmuCodigo { get; set; }

    public byte DocEstado { get; set; }

    public string CodOrientacion { get; set; } = null!;

    public short TinmId { get; set; }

    public double PrecioVentaMin { get; set; }

    public double PrecioVentaMax { get; set; }

    public string Piso { get; set; } = null!;

    public int Filtro { get; set; }

    public byte ClasificaId { get; set; }

    public string PryNumero { get; set; } = null!;

    public int ChkEmpresa { get; set; }

    public int ChkProyecto { get; set; }

    public int ChkRegion { get; set; }

    public int ChkComuna { get; set; }

    public int ChkInmueble { get; set; }

    public int ChkEstado { get; set; }

    public int ChkOrientacion { get; set; }

    public int ChkTipologia { get; set; }

    public int FiltroPrecio { get; set; }

    public int FiltroPiso { get; set; }

    public int ChkClasificacion { get; set; }

    public string TituloMailing { get; set; } = null!;

    public string AsuntoMailing { get; set; } = null!;

    public string BodyMailing { get; set; } = null!;

    public int IdPadreMailing { get; set; }

    public int OptSituacion { get; set; }

    public int TipoSociedad { get; set; }

    public short TcliId { get; set; }

    public decimal PCategoriaId { get; set; }

    public int CmuCodigoCli { get; set; }

    public short AfluId { get; set; }

    public short CodNotaria { get; set; }

    public int ChkTipoSoc { get; set; }

    public int ChkTiCli { get; set; }

    public int ChkCateg { get; set; }

    public int ChkCom { get; set; }

    public int ChkAflu { get; set; }

    public int ChkNot { get; set; }

    public int RdPlanta { get; set; }

    public string InmuebleCodigo { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
