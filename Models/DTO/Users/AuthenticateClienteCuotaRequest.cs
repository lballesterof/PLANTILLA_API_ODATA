using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Models.DTO.Users
{
    public class AuthenticateClienteCuotaRequest
    {
        [Required]
        public string dni { get; set; }

        [Required]
        public string password { get; set; }
    }
}
