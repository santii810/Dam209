using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD3_EJ1.LenguajeADAT
{
    class GestorBD
    {
        SchoolDBEntities context = new SchoolDBEntities();
        public ICollection<Course> obtenerCursos()
        {
            return context.Course.ToList();
        }
        public ICollection<Course> obtenerCursos(int prof)
        {
            return context.Course.Where(k=>k.TeacherId == prof).ToList();
        }

        public ICollection<Student> obtenerEstudiantes()
        {
            return context.Student.ToList();
        }
    }
}
