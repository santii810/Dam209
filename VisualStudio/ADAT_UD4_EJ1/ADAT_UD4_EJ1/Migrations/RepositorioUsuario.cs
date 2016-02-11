using ADAT_UD4_EJ1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD4_EJ1.Migrations
{
    public class RepositorioUsuario : RepositorioGenerico<Asistencia>
    {
        public RepositorioUsuario(Context context)
            : base(context)
        {
        }
    }
}
