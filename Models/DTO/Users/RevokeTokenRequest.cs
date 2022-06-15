using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Models.DTO.Users
{
    public class RevokeTokenRequest
    {
        public string Token { get; set; }
        public string TokenU { get; set; }
    }
}
