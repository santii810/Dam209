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
        public ICollection<Course> obtenerCursosProfesor(int prof)
        {
            return context.Course.Where(k=>k.TeacherId == prof).ToList();
        }

        public ICollection<Student> obtenerEstudiantes()
        {
            return context.Student.ToList();
        }
        public Student obtenerEstudiante(int idEstudiante)
        {
            return context.Student.Where(i => i.StudentID == idEstudiante).FirstOrDefault();
        }
    }
}
