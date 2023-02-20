using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParCargo
{
    public short CgoCodCargo { get; set; }

    public string CgoNombre { get; set; } = null!;

    public string CgoDescripcion { get; set; } = null!;

    public byte CgoIndTrabPesado { get; set; }

    public double CgoPorcentaje { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte CgoIndIdioma { get; set; }

    public decimal PItmAespId { get; set; }

    public decimal PItmNcarrId { get; set; }

    public string CgoRequisitos { get; set; } = null!;

    public virtual ICollection<RhuTFicAntLaborale> RhuTFicAntLaborales { get; } = new List<RhuTFicAntLaborale>();

    public virtual ICollection<RhuTSelCargoPostulante> RhuTSelCargoPostulantes { get; } = new List<RhuTSelCargoPostulante>();

    public virtual ICollection<RhuTSelDocumentoCargo> RhuTSelDocumentoCargos { get; } = new List<RhuTSelDocumentoCargo>();

    public virtual ICollection<RhuTSelEvaluacion> RhuTSelEvaluacions { get; } = new List<RhuTSelEvaluacion>();

    public virtual ICollection<RhuTSelOrdenProceso> RhuTSelOrdenProcesos { get; } = new List<RhuTSelOrdenProceso>();

    public virtual ICollection<RhuTSelPerfil> RhuTSelPerfils { get; } = new List<RhuTSelPerfil>();
}
