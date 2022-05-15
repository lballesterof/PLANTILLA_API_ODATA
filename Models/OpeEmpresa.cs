using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeEmpresa
    {
        public OpeEmpresa()
        {
            OpeSucursals = new HashSet<OpeSucursal>();
        }

        public string CodigoEmpresa { get; set; }
        public string Ruc { get; set; }
        public string Nombre { get; set; }
        public string NombreComercial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string DniRepresentante { get; set; }
        public string Representante { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public byte[] ImagenHeader { get; set; }
        public byte[] ImagenFooter { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public byte[] ImagenBackground { get; set; }
        public string EmpresaPrincipal { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Nota { get; set; }
        public byte[] ImagenPlan { get; set; }
        public string CId { get; set; }
        public string CSt { get; set; }

        public virtual ICollection<OpeSucursal> OpeSucursals { get; set; }
    }
}
