using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD3_EJ3
{
    class Gestor
    {
        CentroMedicoEntities context = new CentroMedicoEntities();

        public void addUsuario(Usuarios usu)
        {
            context.Usuarios.Add(usu);
            context.SaveChanges();
        }

        public ICollection<Usuarios> getUsuarios()
        {
            return context.Usuarios.ToList();
        }



    }
}
