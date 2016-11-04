using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Models.EntityFramework
{
    public class ContextDb
    {
        public class Context : DbContext
        {
            public Context() : base("name=connectionstring")
            {

            }
            public DbSet<Student.Student> Students { get; set; }
            public DbSet<Professor.Professor> Professor { get; set; }
            public DbSet<Subject.Subject> Subjects { get; set; }
        }
    }
}
