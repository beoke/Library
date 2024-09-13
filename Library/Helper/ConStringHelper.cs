using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Helper
{
    public class ConStringHelper
    {
        public static string Get()
         => $"Server=(local);Database=Library;Trusted_Connection=True;TrustServerCertificate=True";
    }
}
