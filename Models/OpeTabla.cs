using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeTabla
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        
        public virtual ICollection<OpeDetalleTabla> detalletabla { get; set; }
    }
}
