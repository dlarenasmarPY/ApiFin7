using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Core.Domain.Entities
{
    public class ClientePromesaDto
    {
        public string inmueble { get; set; }

        public string IdCliente { get; set; }

        public string RutEmpresa { get; set; }

        public string Empresa { get; set; }

        public string Proyecto { get; set; }

        public decimal PtprId { get; set; }

        public string PryNumero { get; set; }

        public string Nombre { get; set; }

        public int CartaOferta { get; set; }

        public string Descripcion { get; set; }

        public string Rut { get; set; }

        public string Direccion { get; set; }

        public string Region { get; set; }

        public string Correo { get; set; }

        public string Celular { get; set; }

        public string Ciudad { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Comuna { get; set; }

        public string EstadoIntegracion { get; set; }

        public List<Cuotas> Cuotas { get; set; }
    }
}
