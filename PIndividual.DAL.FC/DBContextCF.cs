using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIndividual.DAL.FC
{
    public class DBContextCF : DbContext //Se trae los metodos y propiedades por que es publico 
    {
        public DBContextCF()
            : base("name=CFEntities") //el base lo que hace es que me trae el constructor de la clase padre o clase base 
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        //este lo que va a hacer es el enlace con la base de datos de mis entidades
    }
}
