using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaceblazor.DTOs
{
    public class UserToken
    {
        public string Token { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
