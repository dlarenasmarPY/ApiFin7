using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParInstitucione
{
    public decimal InsParId { get; set; }

    public decimal PEntId { get; set; }

    public string InsTipo { get; set; } = null!;

    public short InsCodConversion { get; set; }

    public string InsGlosa { get; set; } = null!;

    public string InsIndFonasa { get; set; } = null!;

    public string InsIndInp { get; set; } = null!;

    public int InsCodSuperInt { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual GlbTEntidad PEnt { get; set; } = null!;

    public virtual ICollection<RhuTApvcEmpresa> RhuTApvcEmpresas { get; } = new List<RhuTApvcEmpresa>();

    public virtual ICollection<RhuTCtoAfiliacionVol> RhuTCtoAfiliacionVols { get; } = new List<RhuTCtoAfiliacionVol>();

    public virtual ICollection<RhuTCtoNominasCf> RhuTCtoNominasCfs { get; } = new List<RhuTCtoNominasCf>();

    public virtual ICollection<RhuTLicMedica> RhuTLicMedicas { get; } = new List<RhuTLicMedica>();

    public virtual ICollection<RhuTLicRmedica> RhuTLicRmedicas { get; } = new List<RhuTLicRmedica>();

    public virtual ICollection<RhuTParVigDatosLeg> RhuTParVigDatosLegLegCajaComps { get; } = new List<RhuTParVigDatosLeg>();

    public virtual ICollection<RhuTParVigDatosLeg> RhuTParVigDatosLegLegMutuals { get; } = new List<RhuTParVigDatosLeg>();

    public virtual ICollection<RhuTParVigInstituc> RhuTParVigInstitucs { get; } = new List<RhuTParVigInstituc>();
}
