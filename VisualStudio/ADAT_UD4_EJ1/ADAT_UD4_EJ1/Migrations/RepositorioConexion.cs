﻿using ADAT_UD4_EJ1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD4_EJ1.Migrations
{
    public class RepositorioConexion : RepositorioGenerico<Asistencia>
    {
        public RepositorioConexion(Context context)
            : base(context)
        {
        }
    }
}